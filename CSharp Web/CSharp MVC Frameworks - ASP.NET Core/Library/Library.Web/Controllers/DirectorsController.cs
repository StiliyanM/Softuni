namespace Library.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services.Contracts;

    public class DirectorsController : Controller
    {
        private readonly IDirectorService directors;

        public DirectorsController(IDirectorService directors)
        {
            this.directors = directors;
        }

        public IActionResult Details(int id)
        {
            if (!this.directors.Exists(id))
            {
                return NotFound();
            }

            var model = this.directors.Details(id);

            return View(model);
        }

    }
}
