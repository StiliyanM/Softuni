namespace GameStore.Application.Controllers
{
    using Services;
    using Services.Contracts;
    using Server.Http.Contracts;
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;
    using Server.Http;
    using ViewModels;

    public class HomeController : BaseController
    {
        private IGameService games;
        private IUserService users;

        public HomeController(IHttpRequest request)
            : base(request)
        {
            this.users = new UserService();
            this.games = new GameService();
        }

        public IHttpResponse Index()
        {
            var filter = "All";
            var gamesToDispay = this.games.AllGames();

            if (this.Request.FormData.Any() && this.Request.FormData["filter"] == "Owned")
            {
                gamesToDispay = games.Owned(this.Request.Session.Get<string>(SessionStore.CurrentUserKey));
            }

            string gamesHtml = GenerateGameHtml(gamesToDispay);

            this.ViewData["games"] = gamesHtml;

            return this.FileViewResponse(@"home\index");
        }

        public IHttpResponse AddToCart()
        {
            var id = int.Parse(Request.UrlParameters["id"]);

            var shoppingCart = Request.Session.Get<ShoppingCart>(ShoppingCart.SessionKey);
            var email = Request.Session.Get<string>(SessionStore.CurrentUserKey);

            if (shoppingCart.ProductIds.Any(e => e == id))
            {
                this.ShowError("This game is already added to your cart!");
                return this.Index();
            }

            if (this.users.OwnsProduct(email, id))
            {
                this.ShowError("You already own this game!");
                return this.Index();
            }

            shoppingCart.ProductIds.Add(id);

            return this.RedirectResponse(HomePath);
        }

        private string GenerateGameHtml(IList<ViewModels.Home.HomeGameListViewModel> games)
        {
            var gamesHtml = new StringBuilder();

            for (int i = 0; i < games.Count; i += 3)
            {
                gamesHtml.AppendLine(@"<div class=""card-group"">");

                var maxGameCount = Math.Min(i + 3, games.Count);

                var adminDisplay = "none";

                if (this.Authentication.IsAdmin)
                {
                    adminDisplay = "inline-block";
                }
                for (int j = i; j < maxGameCount; j++)
                {
                    var game = games[j];

                    gamesHtml.AppendLine($@"<div class=""card col-4 thumbnail"">

                        <img class=""card-image-top img-fluid img-thumbnail""
                                onerror=""this.src='https://i.ytimg.com/vi/{game.VideoId}/maxresdefault.jpg';""
                                src=""https://i.ytimg.com/vi/{game.VideoId}/maxresdefault.jpg"">

                        <div class=""card-body"">
                            <h4 class=""card-title"">{game.Title}</h4>
                            <p class=""card-text""><strong>Price</strong> - {game.Price}&euro;</p>
                            <p class=""card-text""><strong>Size</strong> - {game.Size} GB</p>
                            <p class=""card-text"">{string.Join("", game.Description.Take(300))}</p>
                        </div>

                        <div class=""card-footer"">
                     <a style=""display: {adminDisplay}"" class=""card-button btn btn-outline-warning"" name=""edit"" href=""/admin/games/edit/{game.Id}"">Edit</a>
                                       <a style=""display: {adminDisplay}"" class=""card-button btn btn-danger"" name=""delete"" href=""/admin/games/delete/{game.Id}"">Delete</a>
                            <a class=""card-button btn btn-outline-primary"" name=""info"" href=""/games/{game.Id}"">Info</a>
                            <a class=""card-button btn btn-primary"" name=""buy"" href=""/shopping/add/{game.Id}"">Buy</a>
                        </div>

                    </div>");
                }

                gamesHtml.AppendLine("</div>");

            }

            return gamesHtml.ToString();
        }
    }
}
