using Forum.Models;

namespace Forum.Services.Contracts
{
    public interface IUserService
    {
        bool TryLoginUser(string username, string password);
        User 
    }
}
