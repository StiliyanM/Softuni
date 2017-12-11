using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    static class DeleteUserCommand
    {
        internal static string Execute(string[] data)
        {
            Check.CheckLength(0, data);

            AuthenticationManager.Authorize();

            User currentUser = AuthenticationManager.GetCurrentUser();

            using (var context = new TeamBuilderContext())
            {
                context.Users.Find(currentUser.Id).IsDeleted = true;
                context.SaveChanges();

                AuthenticationManager.Logout();
            }

            return $"User {currentUser.UserName} was successfully deleted!";
        }
    }
}
