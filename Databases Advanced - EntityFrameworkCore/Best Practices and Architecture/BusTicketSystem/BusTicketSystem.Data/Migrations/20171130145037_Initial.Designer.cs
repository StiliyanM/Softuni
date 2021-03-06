﻿// <auto-generated />
using BusTicketSystem.Data;
using BusTicketSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BusTicketSystem.Data.Migrations
{
    [DbContext(typeof(BusTicketSystemContext))]
    [Migration("20171130145037_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusTicketSystem.Models.BankAccount", b =>
                {
                    b.Property<int>("BankAccountId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<decimal>("Balance");

                    b.Property<int>("CustomerId");

                    b.HasKey("BankAccountId");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("BusTicketSystem.Models.BusCompany", b =>
                {
                    b.Property<int>("BusCompanyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<double>("Rating");

                    b.HasKey("BusCompanyId");

                    b.ToTable("BusCompanies");
                });

            modelBuilder.Entity("BusTicketSystem.Models.BusStation", b =>
                {
                    b.Property<int>("BusStationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("TownId");

                    b.HasKey("BusStationId");

                    b.HasIndex("TownId");

                    b.ToTable("BusStations");
                });

            modelBuilder.Entity("BusTicketSystem.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BankAccountId");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Gender");

                    b.Property<int>("HomeTownId");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CustomerId");

                    b.HasIndex("BankAccountId")
                        .IsUnique();

                    b.HasIndex("HomeTownId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BusTicketSystem.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BusCompanyId");

                    b.Property<int>("BusStationId");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("DateAndTimeOfPublishing")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2017, 11, 30, 16, 50, 36, 806, DateTimeKind.Local));

                    b.Property<double>("Grade");

                    b.HasKey("ReviewId");

                    b.HasIndex("BusCompanyId");

                    b.HasIndex("BusStationId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("BusTicketSystem.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<decimal>("Price");

                    b.Property<int>("Seat");

                    b.Property<int>("TripId");

                    b.HasKey("TicketId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TripId");

                    b.HasIndex("TicketId", "TripId", "CustomerId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("BusTicketSystem.Models.Town", b =>
                {
                    b.Property<int>("TownId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("TownId");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("BusTicketSystem.Models.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ArrivalTime");

                    b.Property<int>("BusCompanyId");

                    b.Property<DateTime>("DepartureTime");

                    b.Property<int>("DestinationBusStationId");

                    b.Property<int>("OriginBusStationId");

                    b.Property<int>("Status");

                    b.HasKey("TripId");

                    b.HasIndex("BusCompanyId");

                    b.HasIndex("DestinationBusStationId");

                    b.HasIndex("OriginBusStationId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("BusTicketSystem.Models.BusStation", b =>
                {
                    b.HasOne("BusTicketSystem.Models.Town", "Town")
                        .WithMany("BusStations")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusTicketSystem.Models.Customer", b =>
                {
                    b.HasOne("BusTicketSystem.Models.BankAccount", "BankAccount")
                        .WithOne("Customer")
                        .HasForeignKey("BusTicketSystem.Models.Customer", "BankAccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BusTicketSystem.Models.Town", "HomeTown")
                        .WithMany("Customers")
                        .HasForeignKey("HomeTownId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusTicketSystem.Models.Review", b =>
                {
                    b.HasOne("BusTicketSystem.Models.BusCompany", "BusCompany")
                        .WithMany("Reviews")
                        .HasForeignKey("BusCompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BusTicketSystem.Models.BusStation", "BusStation")
                        .WithMany()
                        .HasForeignKey("BusStationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BusTicketSystem.Models.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BusTicketSystem.Models.Ticket", b =>
                {
                    b.HasOne("BusTicketSystem.Models.Customer", "Customer")
                        .WithMany("Tickets")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BusTicketSystem.Models.Trip", "Trip")
                        .WithMany("Tickets")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusTicketSystem.Models.Trip", b =>
                {
                    b.HasOne("BusTicketSystem.Models.BusCompany", "BusCompany")
                        .WithMany("Trips")
                        .HasForeignKey("BusCompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BusTicketSystem.Models.BusStation", "DestinationBusStation")
                        .WithMany("ArrivalTrips")
                        .HasForeignKey("DestinationBusStationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BusTicketSystem.Models.BusStation", "OriginBusStation")
                        .WithMany("DepartureTrips")
                        .HasForeignKey("OriginBusStationId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
