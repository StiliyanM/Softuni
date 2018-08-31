namespace Library.Services
{
    using Contracts;
    using Data;
    using Library.Services.Models.Authors;
    using System.Linq;
    using System.Collections.Generic;
    using Library.Services.Models;

    public class AuthorService : IAuthorService
    {
        private readonly LibraryDbContext db;

        public AuthorService()
        {
            this.db = new LibraryDbContext();
        }

        public AuthorDetailsModel Details(int id)
        {
            return db.Authors
                .Where(a => a.Id == id)
                .Select(a => new AuthorDetailsModel
                {
                    Name = a.Name,
                    Books = a.Books
                                .Select(b => new BooksByAuthorModel
                                {
                                    Id = b.Id,
                                    Name = b.Title,
                                    Status = b.IsBorrowed ? "Borrowed" : "At Home"
                                }).ToList()
                }).FirstOrDefault();

        }

        public bool Exists(int id)
        {
            return this.db.Authors.Any(a => a.Id == id);
        }

        public IEnumerable<SearchViewModel> Search(string searchTerm)
        {
            using (db)
            {
                return db.Authors
                        .Where(a => a.Name.ToLower().Contains(searchTerm.ToLower()))
                        .Select(a => new SearchViewModel
                        {
                            Id = a.Id,
                            SearchResult = a.Name,
                            Type = "author"
                        }).ToList();
            }
        }
    }
}
