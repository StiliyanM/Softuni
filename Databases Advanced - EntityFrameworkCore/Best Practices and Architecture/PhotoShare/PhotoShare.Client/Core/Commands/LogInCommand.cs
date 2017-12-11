using PhotoShare.Data;
using System;
using System.Linq;

namespace PhotoShare.Client.Core.Commands
{

    public class LogInCommand
    {
        //Login <username> <password>
        public static string Execute(string[] data)
        {
            var username = data[0];
            var password = data[1];

            using (var context = new PhotoShareContext())
            {
                var user = context.Users.
                    FirstOrDefault(u => u.Username == username && u.Password == password);

                if(user == null)
                {
                    throw new ArgumentException("Invalid username or password!");
                }

                if(Session.User != null)
                {
                    throw new ArgumentException("You should logout first!");
                }

                Session.User = user;

                return $"User {username} successfully logged in!";
            }
        }
    }
}
