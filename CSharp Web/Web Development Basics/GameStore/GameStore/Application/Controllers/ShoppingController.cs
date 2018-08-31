namespace GameStore.Application.Controllers
{
    using Server.Http;
    using Server.Http.Contracts;
    using System.Linq;
    using ViewModels;
    using Services;
    using Services.Contracts;
    using System.Text;

    public class ShoppingController : BaseController
    {
        private readonly IUserService users;
        private readonly IGameService games;

        public ShoppingController(IHttpRequest request) : base(request)
        {
            this.games = new GameService();
            this.users = new UserService();
        }

        public IHttpResponse Cart()
        {
            var shoppingCart = Request.Session.Get<ShoppingCart>(ShoppingCart.SessionKey);

            var games = this.games.All(shoppingCart.ProductIds);

            var totalPrice = games.Sum(e => e.Price);

            var gamesHtml = new StringBuilder();
            foreach (var game in games)
            {
                gamesHtml.AppendLine($@"    <div class=""list - group"">
                    <div class=""list-group-item"">
                        <div class=""media"">
                            <a class=""btn btn-outline-danger btn-lg align-self-center mr-3"" href=""/shopping/remove/{game.Id}"">X</a>
                            <img class=""d-flex mr-4 align-self-center img-thumbnail"" height=""127"" src=""{game.Image}""
                                 width=""227"" alt=""Generic placeholder image"">
                            <div class=""media-body align-self-center"">
                                <a href = ""/games/{game.Id}"" >
                                    <h4 class=""mb-1 list-group-item-heading""> {game.Title}</h4>
                                </a>
                                <p>
                                    {game.Description}
                                </p>
                            </div>
                            <div class=""col-md-2 text-center align-self-center mr-auto"">
                                <h2> {game.Price}&euro; </h2>
                            </div>
                        </div>
                    </div>
                    <br />");
            }

            this.ViewData["games"] = gamesHtml.ToString();
            this.ViewData["totalPrice"] = totalPrice.ToString();
            return this.FileViewResponse("/shopping/cart");
        }

        public IHttpResponse RemoveFromCart()
        {
            var id = int.Parse(this.Request.UrlParameters["id"]);

            this.Request.Session.Get<ShoppingCart>(ShoppingCart.SessionKey).ProductIds.Remove(id);

            return this.Cart();
        }

        public IHttpResponse Order()
        {
            var shoppingCart = Request.Session.Get<ShoppingCart>(ShoppingCart.SessionKey);
            var email = Request.Session.Get<string>(SessionStore.CurrentUserKey);

            shoppingCart.RemoveProducts();

            return this.RedirectResponse(HomePath);
        }
    }
}
