using BusTicketSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicketSystem.Data
{
    class TripConfig : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasOne(e => e.BusCompany)
                .WithMany(bs => bs.Trips)
                .HasForeignKey(e => e.BusCompanyId);

            builder.HasOne(e => e.DestinationBusStation)
                .WithMany(b => b.ArrivalTrips)
                .HasForeignKey(e => e.DestinationBusStationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.OriginBusStation)
                .WithMany(b => b.DepartureTrips)
                .HasForeignKey(e => e.OriginBusStationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
