using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static List<BankAccount> accounts;

    static void Main()
    {
        string command;

        accounts = new List<BankAccount>();

        while ((command = Console.ReadLine()) != "End")
        {
            var tokens = command.Split();
            command = tokens[0];

            var id = int.Parse(tokens[1]);
            var acc = accounts.FirstOrDefault(a => a.Id == id);

            if (acc == null && command != "Create")
            {
                Console.WriteLine("Account does not exist");
                continue;
            }

            switch (command)
            {
                case "Create":
                    Create(id);
                    break;
                case "Deposit":
                    var depositAmount = decimal.Parse(tokens[2]);
                    acc.Deposit(depositAmount);
                    break;
                case "Withdraw":
                    var withdrawAmount = decimal.Parse(tokens[2]);
                    acc.Withdraw(withdrawAmount);
                    break;
                case "Print":
                    Console.WriteLine(acc.ToString());
                    break;
            }
        }
    }

    private static void Create(int id)
    {
        var accountExists = accounts.Any(a => a.Id == id);

        if (accountExists)
        {
            Console.WriteLine("Account already exists");
            return;
        }

        var account = new BankAccount(id);

        accounts.Add(account);
    }
}
