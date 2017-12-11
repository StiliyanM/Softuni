using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;

namespace TeamBuilder.App.Core.Commands
{
    static class ShowTeamCommand
    {
        //ShowTeam <teamName>
        internal static string Execute(string[] data)
        {
            Check.CheckLength(1, data);

            var teamName = data[0];

            bool teamExists = CommandHelper.IsTeamExisting(teamName);

            if (!teamExists)
            {
                throw new ArgumentException(string.Format(Constants.ErrorMessages.TeamNotFound, teamName));
            }

            var teamMembers = new StringBuilder();

            using (var context = new TeamBuilderContext())
            {
                var team = context.Teams
                    .Where(t => t.Name == teamName)
                    .Select(t => new
                    {
                        t.Name,
                        t.Acronym,
                        UserNames = t.Members.Select(u => u.User.UserName).ToArray()
                    })
                    .Single();

                teamMembers.AppendLine($"{team.Name} {team.Acronym}");

                teamMembers.AppendLine("Members:");
                foreach (var username in team.UserNames)
                {
                    teamMembers.AppendLine($"--{username}");
                }

                return teamMembers.ToString().TrimEnd();
            }
        }
    }
}
