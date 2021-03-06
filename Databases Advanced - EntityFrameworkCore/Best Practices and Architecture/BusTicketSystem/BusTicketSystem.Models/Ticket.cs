﻿namespace BusTicketSystem.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public decimal Price { get; set; }
        public int Seat { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public Trip Trip { get; set; }
        public int TripId { get; set; }
    }
}
