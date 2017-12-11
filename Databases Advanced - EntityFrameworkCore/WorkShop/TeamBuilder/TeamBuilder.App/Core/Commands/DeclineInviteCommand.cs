using System;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;

namespace TeamBuilder.App.Core.Commands
{
    static class DeclineInviteCommand
    {
        //DeclineInvite <teamName>
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

               var invitation = context.Invitations.First(i => i.Team == team && i.InvitedUser == currentUser);

                context.Invitations.Remove(invitation);

                context.SaveChanges();
            }

            return $"Invite from {teamName} declined.";
        }
    }
}
