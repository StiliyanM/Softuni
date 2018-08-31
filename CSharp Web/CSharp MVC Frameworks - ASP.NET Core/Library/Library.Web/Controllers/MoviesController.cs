namespace Library.Web.Controllers
{
    using Library.Web.Filters;
    using Microsoft.AspNetCore.Mvc;
    using Models.ViewModels;
    using Services.Contracts;

    public class MoviesController : Controller
    {
        private readonly IMovieService movies;
        private readonly IBorrowerService borrowers;
        public MoviesController(IMovieService movies, IBorrowerService borrowers)
        {
            this.movies = movies;
            this.borrowers = borrowers;
        }

        [Authorize]
        public IActionResult Add() => View();

        [HttpPost]
        [Authorize]
        public IActionResult Add(AddMovieViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            this.movies.Create(model.Title, model.Director, model.ImageUrl, model.Description);

            return Redirect("/");
        }

        public IActionResult Details(int id)
        {
            var model = this.movies.ById(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Borrow(int id)
        {
            var model = new BorrowMovieViewModel();

            var movie = this.movies.ById(id);

            if (movie == null)
            {
                return NotFound();
            }

            if (movie.Status == "Borrowed")
            {
                this.ModelState.AddModelError(nameof(movie.Title), "Book is not available!");
            }

            model.Title = movie.Title;
            model.Borrowers = this.borrowers.All();
            return View(model);
        }

        [HttpPost]
        public IActionResult Borrow(int id, BorrowMovieViewModel model)
        {
            var movie = this.movies.ById(id);

            if (movie == null)
            {
                return NotFound();
            }

            model.Title = movie.Title;
            model.Borrowers = this.borrowers.All();

            if (!this.ModelState.IsValid)
            {
                return View(model);
            }

            if (this.movies.HasBeenBorrowed(id, model.Borrower))
            {
                this.ModelState.AddModelError(nameof(movie.Title), "You have already borrowed this book once!");

                return View(model);
            }

            this.movies.Borrow(id, model.Borrower, model.StartDate, model.EndDate);

            return Redirect("/");
        }

        [HttpGet]
        public IActionResult Return(int id)
        {
            this.movies.Return(id);

            return RedirectToAction("Details", new { id = id });
        }

        public IActionResult Status(int id)
        {
            if (!this.movies.Exists(id))
            {
                return NotFound();
            }
            return View(this.movies.GetHistory(id));
        }

        public IActionResult All()
        {
            var allMovies = this.movies.All();

            return View(allMovies);
        }

    }
}
