﻿using Microsoft.EntityFrameworkCore;
using P01_BillsPaymentSystem.Data.Models;

namespace P01_BillsPaymentSystem.Data
{
    public class BillsPaymentSystemContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Models.BankAccount> BankAccounts { get; set; }

        public DbSet<CreditCard> CreditCards { get; set; }

        public DbSet<PaymentMethod> PaymentMethods { get; set; }


        public BillsPaymentSystemContext()
        {

        }

        public BillsPaymentSystemContext(DbContextOptions options)
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new BankAccountConfig());
            modelBuilder.ApplyConfiguration(new CreditCardConfig());
            modelBuilder.ApplyConfiguration(new PaymentMethodConfig());
        }
    }
}
