using BusTicketSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicketSystem.Data
{
    class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasOne(e => e.HomeTown)
                .WithMany(t => t.Customers)
                .HasForeignKey(e => e.HomeTownId);

            builder.HasMany(e => e.Reviews)
                .WithOne(r => r.Customer)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.BankAccount)
                .WithOne(b => b.Customer)
                .HasForeignKey<Customer>(c => c.BankAccountId);

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.LastName)
                 .IsRequired()
                 .HasMaxLength(50);

        }
    }
}
