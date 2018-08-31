namespace Library.Services.Contracts
{
    using System.Collections.Generic;
    using Models;
    using Models.Directors;

    public interface IDirectorService
    {
        DirectorDetailsViewModel Details(int id);

        IEnumerable<SearchViewModel> Search(string searchTerm);

        bool Exists(int id);

    }
}
