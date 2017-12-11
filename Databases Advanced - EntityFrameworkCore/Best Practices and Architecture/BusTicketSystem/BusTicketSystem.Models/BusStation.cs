using System;
using System.Collections.Generic;

namespace BusTicketSystem.Models
{
    public class BusStation
    {
        public int BusStationId { get; set; }
        public string Name { get; set; }

        public Town Town { get; set; }
        public int TownId { get; set; }

        public ICollection<Trip> ArrivalTrips { get; set; } = new List<Trip>();
        public ICollection<Trip> DepartureTrips { get; set; } = new List<Trip>();
    }
}