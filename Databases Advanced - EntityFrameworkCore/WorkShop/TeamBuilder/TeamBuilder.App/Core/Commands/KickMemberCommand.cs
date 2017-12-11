using System;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    static class KickMemberCommand
    {
        //KickMember <teamName> <username>
        internal static string Execute(string[] data)
        {
            Check.CheckLength(2, data);

            var teamName = data[0];
            var userName = data[1];

            var currentUser = AuthenticationManager.GetCurrentUser();

            bool isCurrentUserCreatorOfTeam = CommandHelper.IsUserCreatorOfTeam(teamName, currentUser);

            bool currentUserIsMember = CommandHelper.IsMemberOfTeam(teamName, currentUser.UserName);

            using (var context = new TeamBuilderContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserName == userName);
                var team = context.Teams.FirstOrDefault(t => t.Name == teamName);

                if (user == null || team == null)
                {
                    throw new ArgumentException(Constants.ErrorMessages.TeamOrUserNotExist);
                }

                if (!CommandHelper.IsMemberOfTeam(teamName, user.UserName))
                {
                    throw new ArgumentException(string.Format(Constants.ErrorMessages.NotPartOfTeam, userName, teamName));
                }

                if (!isCurrentUserCreatorOfTeam)
                {
                    throw new InvalidOperationException(Constants.ErrorMessages.NotAllowed);
                }

                if(currentUser == user)
                {
                    throw new InvalidOperationException(string.Format(Constants.ErrorMessages.CommandNotAllowed, "DisbandTeam"));
                }

                UserTeam userTeam = new UserTeam
                {
                    Team = team,
                    User = user
                };

                context.Teams
                    .First(t => t.Name == teamName)
                    .Members.Remove(userTeam);

                context.SaveChanges();

                return $"User {currentUser.UserName} was kicked out from {teamName}!";
            }
        }
    }
}
