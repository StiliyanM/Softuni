﻿namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using Data;

    public class DeleteUser
    {
        // DeleteUser <username>
        public static string Execute(string[] data)
        {
            string username = data[0];

            //Extend
            if(Session.User.Username != username)
            {
                throw new ArgumentException("Invalid credentials!");
            }

            using (PhotoShareContext context = new PhotoShareContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username);
                if (user == null)
                {
                    throw new InvalidOperationException($"User {username} not found!");
                }

                if ((bool)user.IsDeleted)
                {
                    throw new InvalidOperationException($"User {user.Username} is already deleted!");
                }

                user.IsDeleted = true;

                context.SaveChanges();

                return $"User {username} was deleted from the database!";
            }
        }
    }
}
