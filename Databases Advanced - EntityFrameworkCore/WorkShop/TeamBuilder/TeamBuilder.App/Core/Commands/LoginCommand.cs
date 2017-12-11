using System;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    static class LoginCommand
    {
        // Login <username> <password>
        public static string Execute(string[] data)
        {
            Check.CheckLength(2, data);

            string username = data[0];

            string password = data[1];

            if (AuthenticationManager.isAuthenticated())
            {
                throw new InvalidOperationException(Constants.ErrorMessages.LogoutFirst);
            }

            User user = GetUserByUsernameAndPassword(username, password);

            if(user == null)
            {
                throw new ArgumentException(Constants.ErrorMessages.UserOrPasswordIsInvalid);
            }

            AuthenticationManager.Login(user);

            return $"User {user.UserName} successfully logged in!";
        }

        private static User GetUserByUsernameAndPassword(string username, string password)
        {
            using (var context = new TeamBuilderContext())
            {
                var user = context.Users.
                    FirstOrDefault(u => u.UserName == username && u.Password == password && u.IsDeleted == false);
                return user;
            }
        }
    }
}
