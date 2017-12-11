using System;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    static class CreateTeamCommand
    {
        //CreateTeam <name> <acronym> <description> 
        internal static string Execute(string[] data)
        {
            Check.CheckLength(2, data);

            User user = AuthenticationManager.GetCurrentUser();

            var name = data[0];
            var acronym = data[1];
            var description = "";
            if(data.Length == 3)
            description = data[2];

            if (CommandHelper.IsTeamExisting(name))
            {
                throw new ArgumentException(string.Format(Constants.ErrorMessages.TeamExists,name));
            }

            using (var context = new TeamBuilderContext())
            {
                var team = new Team
                {
                    CreatorId = user.Id,
                    Acronym = acronym,
                    Name = name,
                    Description = description == "" ? null : description 
                };

                context.Teams.Add(team);
                context.SaveChanges();

                return $"Team {team.Name} successfully created!";
            }
        }
    }
}
