namespace MeTube.Data
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class MeTubeDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Tube> Tubes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionConfig.ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(u => u.Username)
                .IsUnique();

                entity.HasIndex(u => u.Email)
                .IsUnique();
            });

            base.OnModelCreating(modelBuilder);
        }

        public bool Any()
        {
            throw new NotImplementedException();
        }
    }
}
