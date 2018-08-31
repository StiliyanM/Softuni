namespace KittenApp.Web.Controllers
{
    using SimpleMvc.Framework.Interfaces;
    using Services;
    using Services.Contracts;
    using Services.Models;
    using System.Collections.Generic;
    using System.Text;
    using System;
    using Models;
    using SimpleMvc.Framework.Attributes.Methods;
    using System.Linq;

    public class KittensController : BaseController
    {
        private IKittenService kittenService = new KittenService();

        public IActionResult All()
        {
            var kittens = this.kittenService.All();

            var kittensHtml = GenerateKittensHtml(kittens);

            this.Model.Data["kittens"] = kittensHtml;

            return View();
        }

        public IActionResult Add()
        {
            this.Model.Data["error"] = string.Empty;
            return View();
        }

        [HttpPost]
        public IActionResult Add(KittenBindingModel model)
        {
            if (!this.IsValidModel(model))
            {
                return View();
            }

            var breeds = new string[]
            {
                "Street Transcended", "American Shorthair", "Munchkin", "Siamese"
            };

            if (!breeds.Contains(model.Breed))
            {
                this.Model.Data["error"] = $"{model.Breed} not supported!";

                return View();
            }

            this.kittenService.Create(model.Name, model.Age, model.Breed, model.ImageUrl);

            return RedirectToAction("/kittens/all");
        }

        private string GenerateKittensHtml(IList<AllKitensViewModel> kittens)
        {
            var kittensHtml = new StringBuilder();

            for (int i = 0; i < kittens.Count; i += 3)
            {
                kittensHtml.AppendLine(@"<div class=""card-group"">");

                var maxGameCount = Math.Min(i + 3, kittens.Count);

                for (int j = i; j < maxGameCount; j++)
                {
                    var kitten = kittens[j];

                    kittensHtml.AppendLine($@"<div class=""card col-4 thumbnail"">

                        <img class=""card-image-top img-fluid img-thumbnail""
                                src=""{kitten.ImageUrl}"">

                        <div class=""card-body"">
                            <p class=""card-text""><strong>Name</strong> : {kitten.Name}</p>
                            <p class=""card-text""><strong>Age</strong> : {kitten.Age}</p>
                            <p class=""card-text""><strong>Breed</strong> : {kitten.Breed}</p>
                        </div>
                    </div>");
                }

                kittensHtml.AppendLine("</div>");

            }

            return kittensHtml.ToString();

        }
    }
}
