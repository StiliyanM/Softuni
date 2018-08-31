namespace Library.Services.Contracts
{
    public interface IUserService
    {
        bool Exists(string username, string passwordHash);
    }
}
