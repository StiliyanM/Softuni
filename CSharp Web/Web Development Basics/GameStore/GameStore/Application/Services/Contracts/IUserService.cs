using System.Collections.Generic;

namespace GameStore.Application.Services.Contracts
{
    public interface IUserService
    {
        bool Create(string email, string name, string password);

        bool Find(string email, string password);

        bool IsAdmin(string email);

        bool OwnsProduct(string email, int productId);

        void AddGames(string email, IEnumerable<int> productIds);
    }
}
