namespace Library.Services.Contracts
{
    using System.Collections.Generic;
    using Models.Borrowers;

    public interface IBorrowerService
    {
        void Create(string name, string address);

        bool Exists(string name);

        IEnumerable<AllBorrowersModel> All();
    }
}
