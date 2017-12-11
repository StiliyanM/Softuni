using System;
using P01_BillsPaymentSystem.Data;
using P01_BillsPaymentSystem.Data.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace P01_BillsPaymentSystem
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var userId = int.Parse(Console.ReadLine());
            var amount = int.Parse(Console.ReadLine());

            using (var db = new BillsPaymentSystemContext())
            {
                db.Database.EnsureDeleted();
                db.Database.Migrate();
                //2ра задача
                Seed(db);
            }
            //3та задача
            GetUserDetails(userId);

            //4та
            PayBills(userId, amount);

        }

        private static void GetUserDetails(int userId)
        {
            using (var context = new BillsPaymentSystemContext())
            {
                if (!context.Users.Any(u => u.UserId == userId))
                {
                    Console.WriteLine($"User with id {userId} not found!");
                    return;
                }

                var user = context.Users.Find(userId);

                Console.WriteLine(user.FirstName + " " + user.LastName);

                var paymentMethods = context.PaymentMethods
              .Where(pm => pm.User == user);

                var bankAccounts = paymentMethods
                    .Where(pm => pm.Type == PaymentType.BankAccount)
                    .Select(e => e.BankAccount)
                    .OrderBy(e => e.BankAccountId)
                    .ToList();

                var creditCards = paymentMethods
                    .Where(pm => pm.Type == PaymentType.CreditCard)
                    .Select(e => e.CreditCard)
                    .OrderBy(e => e.CreditCardId)
                    .ToList();

                Console.WriteLine("Bank Accounts:");
                foreach (var bankAccount in bankAccounts)
                {
                    Console.WriteLine(bankAccount);
                }

                Console.WriteLine("Credit Cards:");
                foreach (var creditCard in creditCards)
                {
                    Console.WriteLine(creditCard);
                }
            }
        }

        public static void PayBills(int userId, decimal amount)
        {
            using (var db = new BillsPaymentSystemContext())
            {
                var user = db.Users.Find(userId);

                if (user == null)
                {
                    throw new ArgumentException("There is no such user");
                }

                var paymentMethods = db.PaymentMethods
               .Where(pm => pm.User == user);

                var bankAccounts = paymentMethods
                    .Where(pm => pm.Type == PaymentType.BankAccount)
                    .Select(e => e.BankAccount)
                    .OrderBy(e => e.BankAccountId)
                    .ToList();

                var creditCards = paymentMethods
                    .Where(pm => pm.Type == PaymentType.CreditCard)
                    .Select(e => e.CreditCard)
                    .OrderBy(e => e.CreditCardId)
                    .ToList();

                var totalBalance = bankAccounts.Sum(ba => ba.Balance);
                var totalLimitLeft = creditCards.Sum(cc => cc.LimitLeft);

                if (amount > totalBalance + totalLimitLeft)
                {
                    Console.WriteLine("Insufficient funds!");
                    return;
                }

                    for (int i = 0; i < bankAccounts.Count; i++)
                    {
                    if (amount == 0)
                        break;
                        var amountToWithdraw = 0m;
                        if (bankAccounts[i].Balance - amount < 0)
                        {
                            amountToWithdraw = bankAccounts[i].Balance - amount;
                        }
                        else
                        {
                            amountToWithdraw = amount;
                        }
                        if (amountToWithdraw > 0) 
                        bankAccounts[i].Withdraw(amountToWithdraw);
                        amount -= bankAccounts[i].Balance;
                    }

                    db.SaveChanges();

                    for (int i = 0; i < creditCards.Count; i++)
                    {
                    if (amount == 0)
                        break;

                    var amountToWithdraw = 0m;

                        if (creditCards[0].LimitLeft - amount < 0)
                        {
                            amountToWithdraw = creditCards[0].LimitLeft - amount;
                        }
                        else
                        {
                            amountToWithdraw = amount;
                        }
                        if(amountToWithdraw > 0)
                        creditCards[i].Withdraw(amountToWithdraw);

                    amount -= amountToWithdraw;
                    }

                    db.SaveChanges();
            }
        }

        private static void Seed(BillsPaymentSystemContext context)
        {
            using (context)
            {
                var users = new User[]
    {
                    new User
                    {
                    Email = "ivancho@gmail.com",
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Password = "123",
                    },

                    new User
                    {
                        FirstName = "Stiliyan",
                        LastName = "Milanov",
                        Email = "sm@gmail.com",
                        Password = "123"
                    }
    };

                var bankAccount1 = new BankAccount("Unicredit", "1231dsada");
                bankAccount1.Deposit(250m);

                var bankAccount2 = new BankAccount("Sibank", "dasdg123");
                bankAccount2.Deposit(1000m);

                var bankAccounts = new[]
              {
                    bankAccount1, bankAccount2
                };

                var creditCard1 = new CreditCard();
                creditCard1.ExpirationDate = DateTime.ParseExact("20.12.2018", "dd.MM.yyyy", null);
                creditCard1.Deposit(2000m);

                var creditCard2 = new CreditCard();
                creditCard2.ExpirationDate = DateTime.ParseExact("20.12.2022", "dd.MM.yyyy", null);
                creditCard2.Deposit(1560m);

                var creditCards = new[]
               {
                    creditCard1,creditCard2
                    //new CreditCard
                    //{
                    //    ExpirationDate = DateTime.ParseExact("20.12.2018","dd.MM.yyyy",null),
                    //    Limit = 1550m,
                    //    MoneyOwed = 250
                    //},

                    //new CreditCard
                    //{
                    //    ExpirationDate = DateTime.ParseExact("20.12.2022","dd.MM.yyyy",null),
                    //    Limit = 2200m,
                    //    MoneyOwed = 25m
                    //}
            };
                var paymentMethods = new[]
                {
                    new PaymentMethod
                    {
                        Type = PaymentType.CreditCard,
                        User = users[0],
                        CreditCard = creditCards[0]
                    },

                    new PaymentMethod
                    {
                        Type = PaymentType.CreditCard,
                        User = users[0],
                        CreditCard = creditCards[1]
                    },

                    new PaymentMethod
                    {
                        Type = PaymentType.BankAccount,
                        User = users[0],
                        BankAccount = bankAccounts[1]
                    },

                    new PaymentMethod
                    {
                        Type = PaymentType.BankAccount,
                        User = users[1],
                        BankAccount = bankAccounts[0]
                    },
                    };

                context.Users.AddRange(users);
                context.BankAccounts.AddRange(bankAccounts);
                context.CreditCards.AddRange(creditCards);
                context.PaymentMethods.AddRange(paymentMethods);

                context.SaveChanges();
            }
        }
    }
}