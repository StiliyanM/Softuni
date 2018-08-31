namespace Library.Services
{
    using System.Collections.Generic;
    using Contracts;
    using Library.Services.Models;
    using Library.Services.Models.Directors;
    using Data;
    using System.Linq;

    public class DirectorService : IDirectorService
    {
        private readonly LibraryDbContext db;

        public DirectorService()
        {
            this.db = new LibraryDbContext();
        }

        public DirectorDetailsViewModel Details(int id)
        {
            return db.Directors
                    .Where(d => d.Id == id)
                    .Select(d => new DirectorDetailsViewModel
                    {
                        Name = d.Name,
                        Movies = d.Movies
                                    .Select(b => new MovieByDirectorModel
                                    {
                                        Id = b.Id,
                                        Name = b.Title,
                                        Status = b.IsBorrowed ? "Borrowed" : "At Home"
                                    }).ToList()
                    }).FirstOrDefault();
                
        }

        public bool Exists(int id)
        {
            return this.db.Directors.Any(d => d.Id == id);
        }

        public IEnumerable<SearchViewModel> Search(string searchTerm)
        {
            using (db)
            {
                return db.Directors
                        .Where(d => d.Name.ToLower().Contains(searchTerm.ToLower()))
                        .Select(d => new SearchViewModel
                        {
                            Id = d.Id,
                            SearchResult = d.Name,
                            Type = "director"
                        }).ToList();
            }
        }
    }
}
