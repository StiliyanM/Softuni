using System;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    static class AddTeamToCommand
    {
        //AddTeamTo <eventName> <teamName>
        internal static string Execute(string[] data)
        {
            Check.CheckLength(2, data);

            var currentUser = AuthenticationManager.GetCurrentUser();

            var eventName = data[0];
            var teamName = data[1];

            bool isUserCreatorOfEvent = CommandHelper.IsUserCreatorOfEvent(eventName, currentUser);

            bool teamExists = CommandHelper.IsTeamExisting(teamName);
            bool eventExists = CommandHelper.IsEventExisting(eventName);

            if (!eventExists)
            {
                throw new ArgumentException(string.Format(Constants.ErrorMessages.EventNotFound, eventName));
            }

            if (!teamExists)
            {
                throw new ArgumentException(string.Format(Constants.ErrorMessages.TeamNotFound, teamName));
            }

            if (!isUserCreatorOfEvent)
            {
                throw new InvalidOperationException(Constants.ErrorMessages.NotAllowed);
            }

            using (var context = new TeamBuilderContext())
            {
                var @event = context.Events
                                .Where(e => e.Name == eventName)
                                .OrderByDescending(e => e.StartDate)
                                .First();

                var team = context.Teams.Single(t => t.Name == teamName);

                var eventTeam = new EventTeam
                {
                    Event = @event,
                    Team = team
                };

                bool isTeamAddedToEvent = context.Events.Any(e => e.ParticipatingEventTeams.Any(et => et.Team == team));

                if(isTeamAddedToEvent)
                {
                    throw new InvalidOperationException(Constants.ErrorMessages.CannotAddSameTeamTwice);
                }

                context.Events
                    .Where(e => e.Name == eventName)
                    .OrderByDescending(e => e.StartDate)
                    .First()
                    .ParticipatingEventTeams.Add(eventTeam);

                context.SaveChanges();

                return $"Team {teamName} added for {eventName}!";
            }
        }
    }
}
