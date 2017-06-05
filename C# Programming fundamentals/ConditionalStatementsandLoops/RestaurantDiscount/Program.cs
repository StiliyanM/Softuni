using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            int packagePrice = 0;
            int hallPrice = 0;
            double price = 0;
            double discount = 0;
            string hallName = string.Empty;

            if (groupSize <= 50)
            {
                hallPrice = 2500;
                hallName = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                hallPrice = 5000;
                hallName = "Terrace";
            }
            else if (groupSize <= 120)
            {
                hallPrice = 7500;
                hallName = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if(package == "Normal")
            {
                packagePrice = 500;
                discount = 5;
            }
            else if(package == "Gold")
            {
                packagePrice = 750;
                discount = 10;
            }
            else if(package == "Platinum")
            {
                packagePrice = 1000;
                discount = 15;
            }

            price = packagePrice + hallPrice;
            price *= (100 - discount) / 100;

            double pricePerPerson = price / groupSize;

            Console.WriteLine("We can offer you the " + hallName);
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
        }
    }
}
5