namespace Library.Services.Contracts
{
    using Models.Movies;
    using System;
    using Models;
    using System.Collections.Generic;

    public interface IMovieService
    {
        void Create(string title, string directorName, string imageUrl, string description);
        MovieDetailsModel ById(int id);

        void Return(int id);

        void Borrow(int id, string borrowerName, DateTime startDate, DateTime? endDate);
        bool HasBeenBorrowed(int id, string borrower);

        IEnumerable<SearchViewModel> Search(string searchTerm);

        IEnumerable<HistoryModel> GetHistory(int id);

        bool Exists(int id);

        IEnumerable<MovieListModel> All();
    }
}
