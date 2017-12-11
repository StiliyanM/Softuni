using BusTicketSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BusTicketSystem.Data
{
    class TownConfig : IEntityTypeConfiguration<Town>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Town> builder)
        {
            builder.Property(e => e.Country)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
