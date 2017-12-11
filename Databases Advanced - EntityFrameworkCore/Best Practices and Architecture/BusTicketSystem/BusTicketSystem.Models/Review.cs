using System;
using System.Collections.Generic;

namespace BusTicketSystem.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public double Grade { get; set; }
        public string Content { get; set; }

        public BusStation BusStation { get; set; }
        public int BusStationId { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public DateTime DateAndTimeOfPublishing { get; set; }

        public BusCompany BusCompany { get; set; }
        public int BusCompanyId { get; set; }
    }
}
