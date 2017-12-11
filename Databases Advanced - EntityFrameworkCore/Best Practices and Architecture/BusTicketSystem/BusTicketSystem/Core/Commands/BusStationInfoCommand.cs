namespace BusTicketSystem.App.Core.Commands
{
    using System.Text;
    using Data;
    using System;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public static class BusStationInfoCommand
    {
        // <busStationId>
        internal static string Execute(string[] data)
        {
            var busStationId = int.Parse(data[0]);

            var busStationInfo = new StringBuilder();

            using (var context = new BusTicketSystemContext())
            {
                var info = context.BusStations
                    .Where(bs => bs.BusStationId == busStationId)
                    .Include(bs => bs.Town)
                    .Include(bs => bs.DepartureTrips)
                    .Include(bs => bs.ArrivalTrips)
                    .ToList();

                foreach (var bs in info)
                {
                    busStationInfo.AppendLine($"{bs.Name}, {bs.Town.Name}");

                    busStationInfo.AppendLine("Arrivals:");

                    foreach (var a in bs.ArrivalTrips)
                    {
                        busStationInfo.AppendLine
                        ($"From {a.OriginBusStation.Name} " +
                        $"| Arrive at: {a.ArrivalTime} " +
                        $"| Status: {a.Status}");
                    }

                    busStationInfo.AppendLine("Departures:");

                    foreach (var d in bs.DepartureTrips)
                    {
                        busStationInfo.AppendLine
                        ($"From {d.DestinationBusStation.Name} " +
                        $"| Arrive at: {d.ArrivalTime} " +
                        $"| Status: {d.Status}");
                    }
                }

                return busStationInfo.ToString();
            }
        }
    }
}
