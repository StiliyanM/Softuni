using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var balance = double.Parse(Console.ReadLine());
            double price = 0;
            double totalMoney = balance;
            while (true)
            {
                var game = Console.ReadLine();

                switch (game)
                {
                    case "OutFall 4":
                        price = 39.99;
                        balance -= price;
                        if(balance > 0)
                        Console.WriteLine("Bought " + game);
                        break;
                    case "CS: OG":
                        price = 15.99;
                        balance -= price;
                        if (balance > 0)
                            Console.WriteLine("Bought " + game);
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        balance -= price;
                        if (balance > 0)
                            Console.WriteLine("Bought " + game);
                        break;
                    case "Honored 2":
                        price = 59.99;
                        balance -= price;
                        if (balance > 0)
                            Console.WriteLine("Bought " + game);
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        balance -= price;
                        if (balance > 0)
                            Console.WriteLine("Bought " + game);
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        balance -= price;
                        if (balance > 0)
                            Console.WriteLine("Bought " + game);
                        break;
                    case "Game Time":
                        Console.WriteLine($"Total spent: ${totalMoney - balance:f2}. Remaining: ${balance:f2}");
                        return;

                    default:
                        Console.WriteLine("Not Found");
                        break;

                }

                    if(balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    else if(balance < 0)
                {
                    Console.WriteLine("Too Expensive");
                    balance += price;

                }

                
            }
        }
    }
}
