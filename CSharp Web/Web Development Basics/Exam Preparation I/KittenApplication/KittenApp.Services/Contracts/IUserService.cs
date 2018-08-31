namespace KittenApp.Services.Contracts
{
    public interface IUserService
    {
        void Create(string username, string email, string password);
        bool Exists(string username);
    }
}
