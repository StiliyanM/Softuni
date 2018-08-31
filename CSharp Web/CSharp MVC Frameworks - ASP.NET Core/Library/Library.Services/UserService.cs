namespace Library.Services
{
    using Contracts;
    using Data;
    using System;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    public class UserService : IUserService
    {
        private readonly LibraryDbContext db;

        public UserService()
        {
            this.db = new LibraryDbContext();
        }
        public bool Exists(string username, string password)
        {
            return this.db.Users
                 .Any(u => u.Username == username &&
                 u.PasswordHash.ToLower() == getHashSha256(password).ToLower());
        }

        private static string getHashSha256(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

    }
}
