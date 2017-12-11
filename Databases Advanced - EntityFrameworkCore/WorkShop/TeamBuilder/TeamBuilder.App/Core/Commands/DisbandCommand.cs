using System;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;

namespace TeamBuilder.App.Core.Commands
{
    static class DisbandCommand
    {
        //Disband <teamName>
        internal static string Execute(string[] data)
        {
            Check.CheckLength(1, data);

            var currentUser = AuthenticationManager.GetCurrentUser();

            var teamName = data[0];

            bool isCurrentUserCreatorOfTeam = CommandHelper.IsUserCreatorOfTeam(teamName, currentUser);

            using (var context = new TeamBuilderContext())
            {
                var team = context.Teams.FirstOrDefault(t => t.Name == teamName);

                if (!CommandHelper.IsTeamExisting(teamName))
                {
                    throw new ArgumentException(string.Format(Constants.ErrorMessages.TeamNotFound, teamName));
                }

                if (!isCurrentUserCreatorOfTeam)
                {
                    throw new InvalidOperationException(Constants.ErrorMessages.NotAllowed);
                }

                context.Teams.Remove(team);

                context.SaveChanges();

                return $"{teamName} has disbanded!";
            }
        }
    }
}
