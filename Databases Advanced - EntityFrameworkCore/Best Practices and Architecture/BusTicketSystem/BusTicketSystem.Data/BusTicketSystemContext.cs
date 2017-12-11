using BusTicketSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BusTicketSystem.Data
{
    public class BusTicketSystemContext : DbContext
    {
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<BusCompany> BusCompanies { get; set; }
        public DbSet<BusStation> BusStations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Trip> Trips { get; set; }

        public BusTicketSystemContext()
        {

        }

        public BusTicketSystemContext(DbContextOptions options)
            :base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BankAccountConfig());
            builder.ApplyConfiguration(new BusStationConfig());
            builder.ApplyConfiguration(new BusCompanyConfig());
            builder.ApplyConfiguration(new CustomerConfig());
            builder.ApplyConfiguration(new ReviewConfig());
            builder.ApplyConfiguration(new TripConfig());
            builder.ApplyConfiguration(new TownConfig());
            builder.ApplyConfiguration(new TicketConfig());
        }

    }
}
