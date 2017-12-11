using System;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    static class AcceptInviteCommand
    {
        //AcceptInvite <teamName>
        internal static string Execute(string[] data)
        {
            Check.CheckLength(1, data);

            var teamName = data[0];
            var currentUser = AuthenticationManager.GetCurrentUser();
            bool isTeamExisting = CommandHelper.IsTeamExisting(teamName);

            bool isInviteExisting = CommandHelper.IsInviteExisting(teamName, currentUser);

            if (!isTeamExisting)
            {
                throw new ArgumentException(string.Format(Constants.ErrorMessages.TeamNotFound, teamName));
            }

            if (!isInviteExisting)
            {
                throw new ArgumentException(string.Format(Constants.ErrorMessages.InviteNotFound, teamName));
            }

            using (var context = new TeamBuilderContext())
            {
                var team = context.Teams.First(t => t.Name == teamName);
                UserTeam userTeam = new UserTeam
                {
                    Team = team,
                    UserId = currentUser.Id
                };

                context.Teams
                    .First(t => t.Name == teamName)
                    .Members.Add(userTeam);

                context.SaveChanges();

                return $"User {currentUser.UserName} joined team {teamName}!";
            }
        }
    }
}
