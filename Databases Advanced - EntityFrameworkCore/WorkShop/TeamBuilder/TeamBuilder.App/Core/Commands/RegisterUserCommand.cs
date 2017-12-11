using System;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    public static class RegisterUserCommand
    {
        // RegisterUser <userName> <password> <repeat-password> <firstName>
        //<lastName> <age> <gender>
        public static string Execute(string[] data)
        {
            var userName = data[0];

            if(userName.Length < Constants.MinUsernameLength
                || userName.Length > Constants.MaxUsernameLength)
            {
                throw new ArgumentException
                    (string.Format(Constants.ErrorMessages.UsernameNotValid, userName));
            }

            var password = data[1];

            if(!password.Any(char.IsDigit)|| !password.Any(char.IsUpper))
            {
                throw new ArgumentException
                    (string.Format(Constants.ErrorMessages.PasswordNotValid, password));
            }

            var repeatPassword = data[2];

            if(password != repeatPassword)
            {
                throw new ArgumentException
                    (Constants.ErrorMessages.PasswordDoesNotMatch);
            }

            string firstName = data[3];
            string lastName = data[4];

            int age;

            bool isNumber = int.TryParse(data[5],out age);

            if(!isNumber || age <= 0)
            {
                throw new ArgumentException
                    (Constants.ErrorMessages.AgeNotValid);
            }

            Gender gender;

            bool isGenderValid = Enum.TryParse(data[6], out gender);

            if (!isGenderValid)
            {
                throw new ArgumentException(Constants.ErrorMessages.GenderNotValid);
            }

            if (CommandHelper.IsUserExisting(userName))
            {
                throw new InvalidOperationException
                    (string.Format(Constants.ErrorMessages.UsernameIsTaken,userName));
            }

            RegisterUser(userName, password, firstName, lastName, age, gender);

            return $"User {userName} was registered successfully!";
        }

        private static void RegisterUser(string userName, string password, string firstName, string lastName, int age, Gender gender)
        {
            using (var context = new TeamBuilderContext())
            {
                var user = new User
                {
                    UserName = userName,
                    FirstName = firstName,
                    LastName = lastName,
                    Password = password,
                    Age = age,
                    Gender = gender,
                };

                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
