namespace GameStore.Application.Controllers
{
    using Server.Http.Contracts;
    using Services;
    using Services.Contracts;
    using System;
    using System.Globalization;
    using System.Linq;
    using ViewModels.Admin;

    public class AdminController : BaseController
    {
        private const string AddGameView = @"admin\add-game";
        private const string ListGamesView = @"admin\list-games";
        private const string EditGamesView = @"admin\edit-game";
        private const string DeleteGamesView = @"admin\delete-game";

        private readonly IGameService games;

        public AdminController(IHttpRequest request)
            : base(request)
        {
            this.games = new GameService();
        }

        public IHttpResponse Add()
        {
            if (this.Authentication.IsAdmin)
            {
                return this.FileViewResponse(AddGameView);
            }
            else
            {
                return this.RedirectResponse(HomePath);
            }
        }

        public IHttpResponse Add(AdminGameViewModel model)
        {
            if (!this.Authentication.IsAdmin)
            {
                return this.RedirectResponse(HomePath);
            }

            if (!this.ValidateModel(model))
            {
                return this.Add();
            }

            this.games.Create(
                model.Title,
                model.Description,
                model.Image,
                model.Price,
                model.Size,
                model.VideoId,
                model.ReleaseDate.Value);

            return this.RedirectResponse("/admin/games/list");
        }

        public IHttpResponse Edit()
        {
            if (!this.Authentication.IsAdmin)
            {
                return this.RedirectResponse(HomePath);
            }


            var id = int.Parse(Request.UrlParameters["id"]);

            var game = games.Find(id);

            this.ViewData["title"] = game.Title;
            this.ViewData["description"] = game.Description;
            this.ViewData["thumbnail"] = game.Image;
            this.ViewData["price"] = game.Price.ToString();
            this.ViewData["size"] = game.Size.ToString();
            this.ViewData["videoId"] = game.VideoId;
            this.ViewData["release-date"] = game.ReleaseDate.Value.ToString("yyyy-MM-dd");

            return this.FileViewResponse(EditGamesView);
        }

        public IHttpResponse Edit(AdminGameViewModel model)
        {
            if (!this.Authentication.IsAdmin)
            {
                return this.RedirectResponse(HomePath);
            }

            if (!this.ValidateModel(model))
            {
                return this.Edit();
            }

            var id = int.Parse(Request.UrlParameters["id"]);

            games.Edit(id, model);

            return this.RedirectResponse(HomePath);
        }

        public IHttpResponse Delete()
        {
            if (!this.Authentication.IsAdmin)
            {
                return this.RedirectResponse(HomePath);
            }


            var id = int.Parse(Request.UrlParameters["id"]);

            var game = games.Find(id);

            this.ViewData["title"] = game.Title;
            this.ViewData["description"] = game.Description;
            this.ViewData["thumbnail"] = game.Image;
            this.ViewData["price"] = game.Price.ToString();
            this.ViewData["size"] = game.Size.ToString();
            this.ViewData["videoId"] = game.VideoId;
            this.ViewData["release-date"] = game.ReleaseDate.Value.ToString("yyyy-MM-dd");

            return this.FileViewResponse(DeleteGamesView);
        }

        public IHttpResponse DeletePost()
        {
            var id = int.Parse(Request.UrlParameters["id"]);

            games.Delete(id);

            return this.RedirectResponse("/admin/games/list");
        }

        public IHttpResponse List()
        {
            if (!this.Authentication.IsAdmin)
            {
                return this.RedirectResponse(HomePath);
            }

            var result = this.games
                .All()
                .Select(g => $@"<tr>
                                    <td>{g.Id}</td>
                                    <td>{g.Name}</td>
                                    <td>{g.Size:F2} GB</td>
                                    <td>{g.Price:F2} &euro;</td>
                                    <td>
                                        <a class=""btn btn-warning"" href=""/admin/games/edit/{g.Id}"">Edit</a>
                                        <a class=""btn btn-danger"" href=""/admin/games/delete/{g.Id}"">Delete</a>
                                    </td>
                                </tr>");

            var gamesAsHtml = string.Join(Environment.NewLine, result);

            this.ViewData["games"] = gamesAsHtml;

            return this.FileViewResponse(ListGamesView);
        }
    }
}
