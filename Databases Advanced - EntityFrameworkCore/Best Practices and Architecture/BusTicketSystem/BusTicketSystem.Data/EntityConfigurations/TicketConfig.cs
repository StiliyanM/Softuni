using BusTicketSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicketSystem.Data
{
    class TicketConfig : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(e => e.TicketId);

            builder.HasAlternateKey((e => new { e.TicketId, e.TripId, e.CustomerId }));

            builder.HasOne(e => e.Customer)
                .WithMany(c => c.Tickets)
                .HasForeignKey(e => e.CustomerId);

            builder.HasOne(e => e.Trip)
                .WithMany(t => t.Tickets)
                .HasForeignKey(e => e.TripId);
        }
    }
}
