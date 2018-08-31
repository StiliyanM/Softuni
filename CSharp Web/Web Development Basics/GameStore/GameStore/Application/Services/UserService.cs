namespace GameStore.Application.Services
{
    using Contracts;
    using Data;
    using Data.Models;
    using System.Linq;
    using System.Collections.Generic;
    public class UserService : IUserService
    {
        public bool Create(string email, string name, string password)
        {
            using (var db = new GameStoreDbContext())
            {
                if (db.Users.Any(u => u.Email == email))
                {
                    return false;
                }

                var isAdmin = !db.Users.Any();
                    
                var user = new User
                {
                    Email = email,
                    Name = name,
                    Password = password,
                    IsAdmin = isAdmin
                };

                db.Add(user);
                db.SaveChanges();
            }

            return true;
        }

        public bool Find(string email, string password)
        {
            using (var db = new GameStoreDbContext())
            {
                return db.Users.Any(u => u.Email == email && u.Password == password);
            }
        }

        public bool IsAdmin(string email)
        {
            using (var db = new GameStoreDbContext())
            {
                return db.Users.Any(u => u.Email == email && u.IsAdmin);
            }
        }

        public bool OwnsProduct(string email, int productId)
        {
            using (var db = new GameStoreDbContext())
            {
                return db.Users.Any(u => u.Email == email && u.Games.Any(g => g.GameId == productId));
            }
        }

        public void AddGames(string email, IEnumerable<int> productIds)
        {
            using (var db = new GameStoreDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Email == email);

                var games = db.Games
                        .Where(g => productIds.Contains(g.Id))
                        .Select(g => new UserGame
                        {
                            User = user,
                            Game = g
                        });


                user.Games.AddRange(games);
                db.SaveChanges();
            }
        }
    }
}
