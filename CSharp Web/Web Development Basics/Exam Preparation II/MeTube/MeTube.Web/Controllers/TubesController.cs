namespace MeTube.Web.Controllers
{
    using SimpleMvc.Framework.Interfaces;
    using ViewModels;
    using Models;
    using System.Linq;
    using SimpleMvc.Framework.Attributes.Methods;
    using SimpleMvc.Framework.Attributes.Security;

    public class TubesController : BaseController
    {
        [PreAuthorize]
        public IActionResult Upload()
        {
            this.Model.Data["error"] = string.Empty;
            return View();
        }

        [HttpPost]
        [PreAuthorize]
        public IActionResult Upload(UploadTubeViewModel model)
        {
            if (!this.IsValidModel(model))
            {
                this.Model.Data["error"] = this.ParameterValidator.FirstErrorMessage;

                return View();
            }

            var tube = new Tube
            {
                Author = model.Author,
                Description = model.Description,
                Title = model.Title,
                Uploader = this.Db.Users.FirstOrDefault(u => u.Username == this.User.Name),
                YoutubeId = model.YoutubeLink.Split("?v=").Last()
            };

            Db.Add(tube);
            Db.SaveChanges();

            return this.RedirectToHome();
        }

        [PreAuthorize]
        public IActionResult Details(int id)
        {
            Db.Tubes.FirstOrDefault(t => t.Id == id).Views++;

            Db.SaveChanges();

            var details = Db.Tubes
                    .Where(t => t.Id == id)
                    .Select(t => new TubeDetailsViewModel
                    {
                        Title = t.Title,
                        Author = t.Author,
                        Description = t.Description,
                        Views = t.Views,
                        YoutubeVideoId = t.YoutubeId
                    }).First();

            this.Model.Data["title"] = details.Title;
            this.Model.Data["author"] = details.Author;
            this.Model.Data["description"] = details.Description;
            this.Model.Data["views"] = details.Views.ToString();
            this.Model.Data["videoId"] = details.YoutubeVideoId;

            return View();
        }
    }
}
