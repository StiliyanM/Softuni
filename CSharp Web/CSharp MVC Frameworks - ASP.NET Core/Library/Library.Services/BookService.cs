namespace Library.Services
{
    using System.Collections.Generic;
    using Contracts;
    using Library.Services.Models.Books;
    using Data;
    using Library.Models;
    using System.Linq;
    using System;
    using Models;
    public class BookService : IBookService
    {
        private readonly LibraryDbContext db;

        public BookService()
        {
            this.db = new LibraryDbContext();

        }
        public IEnumerable<BookListModel> All()
        {
            using (db)
            {
                return this.db.Books
                        .Select(b => new BookListModel
                        {
                            Id = b.Id,
                            Author = b.Author.Name,
                            AuthorId = b.AuthorId,
                            Status = b.IsBorrowed ? "Borrowed" : "At Home",
                            Title = b.Title
                        }).ToList();

            }
        }

        public BookDetailsModel ById(int id)
        {
            return this.db.Books.Where(b => b.Id == id)
                    .Select(b => new BookDetailsModel
                    {
                        Author = b.Author.Name,
                        Description = b.Description,
                        ImageUrl = b.CoverImageUrl,
                        Title = b.Title,
                        Status = b.IsBorrowed ? "Borrowed" : "At Home"
                    }).FirstOrDefault();
        }

        public void Create(string title, string authorName, string imageUrl, string description)
        {
            using (db)
            {
                var author = db.Authors.FirstOrDefault(a => a.Name == authorName);

                if (author == null)
                {
                    author = new Author
                    {
                        Name = authorName
                    };
                }

                var book = new Book
                {
                    Author = author,
                    Title = title,
                    CoverImageUrl = imageUrl,
                    Description = description
                };

                db.Add(book);
                db.SaveChanges();
            }
        }

        public bool Exists(string title)
        {
            using (db)
            {
                return this.db.Books.Any(b => b.Title == title);
            }
        }

        public void Borrow(int id, string borrowerName, DateTime startDate, DateTime? endDate)
        {
            this.db.Books.Find(id).IsBorrowed = true;

            this.db.BooksBorrowed.Add(new BooksBorrower
            {
                BookId = id,
                StartDate = startDate,
                EndDate = endDate,
                BorrowerId = this.db.Borrowers.FirstOrDefault(b => b.Name == borrowerName).Id
            });

            this.db.SaveChanges();

        }

        public void Return(int id)
        {
            using (db)
            {
                var book = this.db.Books.Find(id);
                book.IsBorrowed = false;
                this.db.BooksBorrowed.Where(b => b.BookId == id).Last().EndDate = DateTime.Now;
                this.db.SaveChanges();
            }

        }

        public IEnumerable<SearchViewModel> Search(string searchTerm)
        {
            using (db)
            {
                return this.db.Books
                        .Where(b => b.Title.ToLower().Contains(searchTerm.ToLower()))
                        .Select(b => new SearchViewModel
                        {
                            Id = b.Id,
                            SearchResult = b.Title,
                            Type = "book"
                        }).ToList();
            }
        }

        public IEnumerable<HistoryModel> GetHistory(int id)
        {
            using (db)
            {
                return this.db.BooksBorrowed
                        .Where(bb => bb.BookId == id)
                        .Select(bb => new HistoryModel
                        {
                            Title = bb.Book.Title,
                            Borrower = bb.Borrower.Name,
                            StartDate = bb.StartDate,
                            EndDate = bb.EndDate
                        }).ToList();
            }
        }

        public bool HasBeenBorrowed(int bookId, string borrowerName)
        {
            return this.db.BooksBorrowed.Any(b => b.BookId == bookId && b.Borrower.Name == borrowerName);
        }
    }
}
