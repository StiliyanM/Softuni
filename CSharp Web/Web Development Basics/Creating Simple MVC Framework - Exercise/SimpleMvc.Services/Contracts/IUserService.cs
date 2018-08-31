namespace SimpleMvc.Services.Contracts
{
    using Models;
    using System.Collections.Generic;

    public interface IUserService
    {
        void Create(string username, string password);

        User ById(int id);

        IEnumerable<User> All();

        IEnumerable<Note> GetNotes(int id);
        bool Exists(string username, string password);
    }
}
