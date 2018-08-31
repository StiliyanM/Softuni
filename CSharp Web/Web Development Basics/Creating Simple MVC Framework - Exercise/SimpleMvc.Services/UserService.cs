namespace SimpleMvc.Services
{
    using System.Collections.Generic;
    using Contracts;
    using Data;
    using Models;
    using System.Linq;
    
    public class UserService : IUserService
    {
        public IEnumerable<User> All()
        {
            using (var db = new NotesDbContext())
            {
                return db.Users
                    .ToList();                    
            }
        }

        public User ById(int id)
        {
            using (var db = new NotesDbContext())
            {
                return db.Users.FirstOrDefault(u => u.Id == id);
            }
        }

        public void Create(string username, string password)
        {
            using (var db = new NotesDbContext())
            {
                var user = new User
                {
                    Username = username,
                    Password = password
                };

                db.Add(user);

                db.SaveChanges();
            }
        }

        public bool Exists(string username, string password)
        {
            using (var db = new NotesDbContext())
            {
                return db.Users
                    .Any(u => u.Username == username && u.Password == password);
            }
        }

        public IEnumerable<Note> GetNotes(int id)
        {
            using (var db = new NotesDbContext())
            {
                return db.Notes.Where(n => n.OwnerId == id).ToList();
            }
        }
    }
}
