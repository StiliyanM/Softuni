namespace Library.Services.Contracts
{
    using Models.Authors;
    using System.Collections.Generic;
    using Models;
    public interface IAuthorService
    {
        AuthorDetailsModel Details(int id);

        IEnumerable<SearchViewModel> Search(string searchTerm);
        bool Exists(int id);
    }
}
