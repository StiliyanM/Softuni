﻿using System;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core
{
    public class AuthenticationManager
    {
        private static User currentUser;

        public static void Login(User user)
        {
            if(isAuthenticated())
            {
                throw new InvalidOperationException(Constants.ErrorMessages.LogoutFirst);
            }
            currentUser = user;
        }

        public static void Logout()
        {
            Authorize();

            currentUser = null;
        }

       public static bool isAuthenticated()
        {
            if (currentUser == null)
                return false;
            else
                return true;
        }

        public static User GetCurrentUser()
        {
            Authorize();

            return currentUser;
        }

        public static void Authorize()
        {
            if (currentUser == null)
            {
                throw new InvalidOperationException(Constants.ErrorMessages.LoginFirst);
            }
        }
    }
}
