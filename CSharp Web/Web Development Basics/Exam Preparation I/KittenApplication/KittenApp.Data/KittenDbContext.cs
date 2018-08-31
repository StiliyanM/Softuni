namespace KittenApp.Data
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using System;

    public class KittenDbContext : DbContext
    {
        public KittenDbContext( DbContextOptions options) : base(options)
        {
        }

        public KittenDbContext()
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Kitten> Kittens { get; set; }

        public DbSet<Breed> Breeds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-HO1UOB5\SQLEXPRESS;Database=Blogging;Trusted_Connection=True;");
            }
        }

        public bool Any()
        {
            throw new NotImplementedException();
        }
    }
}
