namespace KittenApp.Services
{
    using Contracts;
    using Data;
    using KittenApp.Models;
    using System.Linq;
    public class UserService : IUserService
    {
        private readonly KittenDbContext db = new KittenDbContext();

        public void Create(string username, string email, string password)
        {
            var user = new User
            {
                Email = email,
                Username = username,
                Password = password
            };

            db.Add(user);

            db.SaveChanges();
        }

        public bool Exists(string username) => this.db.Users.Any(u => u.Username == username);
    }
}
