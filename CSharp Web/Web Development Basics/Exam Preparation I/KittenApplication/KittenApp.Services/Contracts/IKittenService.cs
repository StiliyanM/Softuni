namespace KittenApp.Services.Contracts
{
    using Models;
    using System.Collections.Generic;

    public interface IKittenService
    {
        IList<AllKitensViewModel> All();
        void Create(string name, int age, string breed, string imageUrl);
    }
}
