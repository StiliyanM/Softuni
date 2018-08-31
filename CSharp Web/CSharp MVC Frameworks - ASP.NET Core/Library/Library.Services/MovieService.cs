namespace Library.Services
{
    using Contracts;
    using Library.Data;
    using Library.Models;
    using Library.Services.Models;
    using Library.Services.Models.Movies;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MovieService : IMovieService
    {
        private readonly LibraryDbContext db;

        public MovieService()
        {
            this.db = new LibraryDbContext();

        }

        public IEnumerable<MovieListModel> All()
        {
            using (db)
            {
                return this.db.Movies
                        .Select(m => new MovieListModel
                        {
                            Id = m.Id,
                            Director = m.Director.Name,
                            DirectorId = m.DirectorId,
                            Status = m.IsBorrowed ? "Borrowed" : "At Home",
                            Title = m.Title
                        }).ToList();

            }
        }

        public void Borrow(int id, string borrowerName, DateTime startDate, DateTime? endDate)
        {
            this.db.Movies.Find(id).IsBorrowed = true;

            this.db.MoviesBorrowed.Add(new MoviesBorrower
            {
                MovieId = id,
                StartDate = startDate,
                EndDate = endDate,
                BorrowerId = this.db.Borrowers.FirstOrDefault(b => b.Name == borrowerName).Id
            });

            this.db.SaveChanges();
        }

        public MovieDetailsModel ById(int id)
        {
            return this.db.Movies.Where(m => m.Id == id)
                    .Select(m => new MovieDetailsModel
                    {
                        Id = id,
                        Director = m.Director.Name,
                        Description = m.Description,
                        ImageUrl = m.CoverImageUrl,
                        Title = m.Title,
                        Status = m.IsBorrowed ? "Borrowed" : "At Home"
                    }).FirstOrDefault();

        }

        public void Create(string title, string directorName, string imageUrl, string description)
        {
            using (db)
            {
                var director = db.Directors.FirstOrDefault(a => a.Name == directorName);

                if (director == null)
                {
                    director = new Director
                    {
                        Name = directorName
                    };
                }

                var movie = new Movie
                {
                    Director = director,
                    Title = title,
                    CoverImageUrl = imageUrl,
                    Description = description
                };

                db.Add(movie);
                db.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return this.db.Movies.Any(m => m.Id == id);
        }

        public IEnumerable<HistoryModel> GetHistory(int id)
        {
            using (db)
            {
                return this.db.MoviesBorrowed
                        .Where(mb => mb.MovieId == id)
                        .Select(mb => new HistoryModel
                        {
                            Title = mb.Movie.Title,
                            Borrower = mb.Borrower.Name,
                            StartDate = mb.StartDate,
                            EndDate = mb.EndDate
                        }).ToList();
            }

        }

        public bool HasBeenBorrowed(int id, string borrower)
        {
            return this.db.MoviesBorrowed.Any(b => b.MovieId == id && b.Borrower.Name == borrower);
        }

        public void Return(int id)
        {
            using (db)
            {
                var movie = this.db.Movies.Find(id);
                movie.IsBorrowed = false;
                this.db.MoviesBorrowed.Where(b => b.MovieId == id).Last().EndDate = DateTime.Now;
                this.db.SaveChanges();
            }

        }

        public IEnumerable<SearchViewModel> Search(string searchTerm)
        {
            using (db)
            {
                return this.db.Movies
                        .Where(m => m.Title.ToLower().Contains(searchTerm.ToLower()))
                        .Select(m => new SearchViewModel
                        {
                            Id = m.Id,
                            SearchResult = m.Title,
                            Type = "movie"
                        }).ToList();
            }

        }
    }
}
