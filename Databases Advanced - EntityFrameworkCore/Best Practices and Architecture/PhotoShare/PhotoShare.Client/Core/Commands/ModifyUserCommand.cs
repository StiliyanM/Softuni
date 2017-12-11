namespace PhotoShare.Client.Core.Commands
{
    using PhotoShare.Data;
    using PhotoShare.Models;
    using System;
    using System.Linq;

    public class ModifyUserCommand
    {
        // ModifyUser <username> <property> <new value>
        // For example:
        // ModifyUser <username> Password <NewPassword>
        // ModifyUser <username> BornTown <newBornTownName>
        // ModifyUser <username> CurrentTown <newCurrentTownName>
        // !!! Cannot change username
        public static string Execute(string[] data)
        {
            var username = data[0];
            var property = data[1];
            var newValue = data[2];

            //Extend
            if(Session.User.Username != username)
            {
                throw new InvalidOperationException("Invalid credentials!");
            }

            using (var context = new PhotoShareContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username);

                if(user == null)
                {
                    throw new ArgumentException($"User {username} not found!");
                }

                switch (property)
                {
                    case "Password":
                        if(!(newValue.Any( ch => char.IsDigit(ch)) && newValue.Any(ch => char.IsLower(ch))))
                        {
                            throw new ArgumentException($"Value {newValue} not valid." + Environment.NewLine +
                                "Invalid Password");
                        }
                        user.Password = newValue;

                        context.SaveChanges();
                        break;

                    case "BornTown":

                        var town = context.Towns.FirstOrDefault(t => t.Name == newValue);

                        if(town == null)
                        {
                            throw new ArgumentException(($"Value {newValue} not valid." + Environment.NewLine +
                                $"Town {newValue} not found!"));
                        }

                        user.BornTown = new Town();
                        user.BornTown = town;
                        context.SaveChanges();
                        break;

                    case "CurrentTown":

                        var currentTown = context.Towns.FirstOrDefault(t => t.Name == newValue);

                        if (currentTown == null)
                        {
                            throw new ArgumentException(($"Value {newValue} not valid." + Environment.NewLine +
                                $"Town {newValue} not found!"));
                        }

                        user.CurrentTown = new Town();
                        user.CurrentTown = currentTown;
                        context.SaveChanges();
                        break;

                    default:
                        throw new ArgumentException($"Property {property} not supported!");
    }

                return $"User {user.Username} {property} is {newValue}.";
            }
        }
    }
}
