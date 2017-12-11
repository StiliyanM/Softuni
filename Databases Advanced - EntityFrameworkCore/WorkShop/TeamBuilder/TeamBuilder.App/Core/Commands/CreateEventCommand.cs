using System;
using System.Globalization;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    static class CreateEventCommand
    {
        //CreateEvent<name> <description> <startDate> <endDate>
        internal static string Execute(string[] data)
        {
            Check.CheckLength(6, data);

            User user = AuthenticationManager.GetCurrentUser();

            var name = data[0];

            var description = data[1];

            DateTime startDate;
            DateTime endDate;

            if(!DateTime.TryParseExact(data[2] +  " " + data[3],Constants.DateTimeFormat,CultureInfo.InvariantCulture,DateTimeStyles.None, out startDate))
            {
                throw new ArgumentException(Constants.ErrorMessages.InvalidDateFormat);
            }

            if(!DateTime.TryParseExact(data[4] + " " + data[5],Constants.DateTimeFormat, CultureInfo.InvariantCulture,DateTimeStyles.None ,out endDate))
            {
                throw new ArgumentException(Constants.ErrorMessages.InvalidDateFormat);
            }

            if(startDate > endDate)
            {
                throw new ArgumentException("Start date should be before end date. ");
            }

            using (var context = new TeamBuilderContext())
            {
                var @event = new Event
                {
                    CreatorId = user.Id,
                    Description = description,
                    EndDate = endDate,
                    StartDate = startDate,
                    Name = name
                };

                context.Events.Add(@event);
                context.SaveChanges();
            }

            return $"Event {name} was created successfully!";
        }
    }
}
