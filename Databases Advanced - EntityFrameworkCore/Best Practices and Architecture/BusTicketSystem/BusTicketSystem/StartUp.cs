using BusTicketSystem.Data;
using BusTicketSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BusTicketSystem.App
{
    class StartUp
    {
        static void Main()
        {
            //ResetDatabase();

            CommandDispatcher commandDispatcher = new CommandDispatcher();
            Engine engine = new Engine(commandDispatcher);
            engine.Run();
        }

        private static void Seed(BusTicketSystemContext context)
        {
                var towns = new[]
{
                    new Town
                    {
                        Name = "Sofia",
                        Country = "Bulgaria",
                    },
                    new Town
                    {
                        Name = "New York",
                        Country = "USA"
                    },

                };
                context.Towns.AddRange(towns);

                var busCompanies = new[]
                {
                    new BusCompany
                    {
                        Name = "Union Ivkoni",
                        Nationality = "BG",
                        Rating = 7.6,
                    },
                     new BusCompany
                    {
                        Name = "American",
                        Nationality = "US",
                        Rating = 9.0
                    },
                };
                context.BusCompanies.AddRange(busCompanies);

                var busStations = new[]
{
                    new BusStation
                    {
                        Name = "Union",
                        Town = towns[1]
                    },
                    new BusStation
                    {
                        Name = "Centralna",
                        Town = towns[0]
                    },

                };
                context.BusStations.AddRange(busStations);

                var bankAccounts = new[]
                {
                    new BankAccount
                    {
                        AccountNumber = "1231236",
                        Balance = 2000,
                    },
                    new BankAccount
                    {
                        AccountNumber = "5453789",
                        Balance = 1000,
                    }
                };
                context.BankAccounts.AddRange(bankAccounts);

                var trips = new[]
                {
                    new Trip
                    {
                        BusCompany = busCompanies[0],
                        DestinationBusStation = busStations[1],
                        OriginBusStation = busStations[0],
                        DepartureTime = DateTime.Now,
                        ArrivalTime = DateTime.Parse("12/01/2017"),
                        Status = Status.Departed
                    },

                    new Trip
                    {
                        BusCompany = busCompanies[1],
                        DestinationBusStation = busStations[0],
                        OriginBusStation = busStations[1],
                        DepartureTime = DateTime.Now,
                        ArrivalTime = DateTime.Parse("12/02/2017"),
                        Status = Status.Delayed
                    },

                };
                context.Trips.AddRange(trips);

                var customers = new[]
                {
                    new Customer
                    {
                        FirstName = "Stiliyan",
                        LastName = "Milanov",
                        Gender = Gender.Male,
                        HomeTown = towns[0],
                        BankAccount = bankAccounts[0],
                    },
                    new Customer
                    {
                        FirstName = "Emma",
                        LastName = "Stone",
                        Gender = Gender.Female,
                        HomeTown = towns[1],
                        BankAccount = bankAccounts[1],
                    }

                };
                context.Customers.AddRange(customers);

                var tickets = new[] 
                {
                    new Ticket
                    {
                        Price = 50,
                        Seat = 23,
                        Customer = customers[0],
                        Trip = trips[0],
                    },
                    new Ticket
                    {
                        Price = 100,
                        Seat = 33,
                        Customer = customers[1],
                        Trip = trips[1],
                    }

                };
                context.Tickets.AddRange(tickets);

                var reviews = new[]
                {
                    new Review
                    {
                        BusCompany = busCompanies[0],
                        BusStation = busStations[0],
                        Customer = customers[0],
                        Content = "Mnogo zle",
                        Grade = 3.6,
                    },
                    new Review
                    {
                        BusCompany = busCompanies[1],
                        BusStation = busStations[1],
                        Customer = customers[1],
                        Content = "Ekstra",
                        Grade = 7.9,
                    }
                };
                context.Reviews.AddRange(reviews);

                context.SaveChanges();    
        }

        private static void ResetDatabase()
        {
            using (var context = new BusTicketSystemContext())
            {
                context.Database.EnsureDeleted();
                context.Database.Migrate();

                Seed(context);
            }
        }
    }
}
