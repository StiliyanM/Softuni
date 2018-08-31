namespace GameStore.Application.Controllers
{
    using Server.Http.Contracts;
    using Services;
    using Services.Contracts;
    using ViewModels.Games;

    public class GamesController : BaseController
    {
        IGameService games = new GameService();

        public GamesController(IHttpRequest request) : base(request)
        {
        }

        public IHttpResponse Details()
        {
            var id = int.Parse(Request.UrlParameters["id"]);

            var adminDisplay = "none";

            if (this.Authentication.IsAdmin)
            {
                adminDisplay = "inline-block";
            }
            var game = games.Details(id);

            this.ViewData["id"] = game.Id.ToString();
            this.ViewData["title"] = game.Title;
            this.ViewData["description"] = game.Description;
            this.ViewData["price"] = game.Price.ToString();
            this.ViewData["size"] = game.Size.ToString();
            this.ViewData["videoId"] = game.VideoId;
            this.ViewData["release-date"] = game.ReleaseDate.ToString("yyyy-MM-dd");
            this.ViewData["adminDisplay"] = adminDisplay;

            return this.FileViewResponse($"/games/details");

        }
    }
}
