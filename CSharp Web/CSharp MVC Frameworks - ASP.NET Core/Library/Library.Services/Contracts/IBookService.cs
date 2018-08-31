namespace Library.Services.Contracts
{
    using Models.Books;
    using System;
    using System.Collections.Generic;
    using Models;
    public interface IBookService
    {
        IEnumerable<BookListModel> All();

        void Create(string title, string authorName, string imageUrl, string description);

        BookDetailsModel ById(int id);

        IEnumerable<SearchViewModel> Search(string searchTerm);

        bool Exists(string title);

        void Return(int id);

        void Borrow(int id, string borrowerName, DateTime startDate, DateTime? endDate);

        IEnumerable<HistoryModel> GetHistory(int id);

        bool HasBeenBorrowed(int bookId, string borrowerName);
    }
}
