using TeamBuilder.App.Utilities;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    static class LogoutCommand
    {
        internal static string Execute(string[] data)
        {
            Check.CheckLength(0, data);

            User user = AuthenticationManager.GetCurrentUser();

            AuthenticationManager.Logout();

            return $"User {user.UserName} logged out successfully";
        }
    }
}
