using System;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    static class InviteToTeamCommand
    {
        //InviteToTeam <teamName> <username>
        internal static string Execute(string[] data)
        {
            Check.CheckLength(2, data);

            var currentUser = AuthenticationManager.GetCurrentUser();

            var teamName = data[0];
            var userName = data[1];
            using (var context = new TeamBuilderContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserName == userName);
                var team = context.Teams.FirstOrDefault(t => t.Name == teamName);

                if (user == null || team == null)
                {
                    throw new ArgumentException(Constants.ErrorMessages.TeamOrUserNotExist);
                }

                bool isUserCreatorOfTeam = CommandHelper.IsUserCreatorOfTeam(teamName, currentUser);

                bool currentUserIsMember = CommandHelper.IsMemberOfTeam(teamName, currentUser.UserName);

                if (!(!isUserCreatorOfTeam || !currentUserIsMember
                   || CommandHelper.IsMemberOfTeam(teamName, userName)))
                {
                    throw new ArgumentException(Constants.ErrorMessages.NotAllowed);
                }

                if (CommandHelper.IsInviteExisting(teamName, user))
                {
                    throw new InvalidOperationException(Constants.ErrorMessages.InviteIsAlreadySent);
                }

                Invitation invitation = new Invitation
                {
                    InvitedUser = user,
                    Team = team
                };
                context.Invitations.Add(invitation);

                context.SaveChanges();
            }

            return $"Team {teamName} invited {userName}!";
        }
    }
}
