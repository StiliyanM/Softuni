using BusTicketSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BusTicketSystem.Data
{
    class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.Property(e => e.Content)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.DateAndTimeOfPublishing)
                .HasDefaultValue(DateTime.Now);

            //builder.HasOne(e => e.BusCompany)
            //    .WithMany(bs => bs.Reviews)
            //    .HasForeignKey(e => e.BusCompanyId);
        }
    }
}
