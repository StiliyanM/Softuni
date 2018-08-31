namespace MeTube.Web.Controllers
{
    using SimpleMvc.Framework.Interfaces;
    using System;
    using System.Linq;
    using System.Text;
    using ViewModels;
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            if (!this.User.IsAuthenticated)
            {
                this.Model.Data["homeContent"] = $@"<div class=""jumbotron"">
                                <p class=""h1 display-3"">Welcome to MeTube&trade;!</p>
                                <p class=""h3"">The simplest, easiest to use, most comfortable Multimedia Application.</p>
                                <hr class=""my-3"">
                                <p><a href=""/users/login"">Login</a> if you have an account or <a href=""/users/register"">Register</a> now and start tubing.</p></div>
                                ";
            }
            else
            {
                var result = new StringBuilder();
                result.AppendLine($@"<h3 class=""text-info text-center"">Welcome, {this.User.Name}</h3>");
                result.AppendLine("</br>");

                var tubes = this.Db.Tubes
                    .Select(t => new TubeListViewModel
                    {
                        Id = t.Id,
                        Author = t.Author,
                        Title = t.Title,
                        VideoId = t.YoutubeId
                    }).ToList();
             
                for (int i = 0; i < tubes.Count; i+=3)
                {
                    var maxCount = Math.Min(tubes.Count - i, 3);

                    result.AppendLine($@"<div class=""row"">");

                    for (int j = i; j < maxCount + i; j++)
                    {
                        var model = tubes[j];

                        result.AppendLine($@"    <div class=""col-md-4 text-center"">
                                            <a href=""/tubes/details?id={model.Id}"">
                                            <img src=""https://img.youtube.com/vi/{model.VideoId}/maxresdefault.jpg""  
                                                alt=""{model.Title}""  class=""img-thumbnail"">
                                            </a>
                                            <h4>
                                                {model.Title}
                                            </h4>
                                            <h5><em>{model.Author}</em></h5>
                                            </div>");
                    }

                    result.AppendLine("</div>");

                }

                this.Model.Data["homeContent"] = result.ToString();

            }

            return View();
        }
    }
}
