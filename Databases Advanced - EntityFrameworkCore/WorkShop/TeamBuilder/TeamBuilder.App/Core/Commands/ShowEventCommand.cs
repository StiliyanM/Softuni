using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;

namespace TeamBuilder.App.Core.Commands
{
    static class ShowEventCommand
    {
        //EventTeam <eventName>
        internal static string Execute(string[] data)
        {
            Check.CheckLength(1, data);

            var eventName = data[0];

            bool eventExists = CommandHelper.IsEventExisting(eventName);

            if (!eventExists)
            {
                throw new ArgumentException(string.Format(Constants.ErrorMessages.EventNotFound, eventName));
            }

            var eventTeams = new StringBuilder();

            using (var context = new TeamBuilderContext())
            {
                var @event = context.Events
                    .Where(e => e.Name == eventName)
                    .Select(e => new
                    {
                        e.Name,
                        e.StartDate,
                        e.EndDate,
                        e.Description,
                        TeamNames = e.ParticipatingEventTeams.
                                        Select(p => p.Team.Name).ToArray()
                    })
                    .OrderByDescending(e => e.StartDate)
                    .First();

                eventTeams.AppendLine($"{@event.Name} {@event.StartDate} {@event.EndDate}");
                eventTeams.AppendLine($"{@event.Description}");
                
                eventTeams.AppendLine("Teams:");
                foreach (var name in @event.TeamNames)
                {
                    eventTeams.AppendLine($"--{name}");
                }

                return eventTeams.ToString().TrimEnd();
            }
        }
    }
}
