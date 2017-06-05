using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var amount = double.Parse(Console.ReadLine());

            if(city == "sofia")
            {
                if(product == "coffee")
                    Console.WriteLine(0.50 * amount);
                else if(product == "water")
                    Console.WriteLine(0.80 * amount);
                else if (product == "beer")
                    Console.WriteLine(1.20 * amount);
                else if (product == "sweets")
                    Console.WriteLine(1.45 * amount);
                else if (product == "peanuts")
                    Console.WriteLine(1.60 * amount);
            }
            else if(city == "plovdiv")
            {
                if (product == "coffee")
                    Console.WriteLine(0.40 * amount);
                else if (product == "water")
                    Console.WriteLine(0.70 * amount);
                else if (product == "beer")
                    Console.WriteLine(1.15 * amount);
                else if (product == "sweets")
                    Console.WriteLine(1.30 * amount);
                else if (product == "peanuts")
                    Console.WriteLine(1.50 * amount);
            }
            else if(city == "varna")
            {
                if (product == "coffee")
                    Console.WriteLine(0.45 * amount);
                else if (product == "water")
                    Console.WriteLine(0.70 * amount);
                else if (product == "beer")
                    Console.WriteLine(1.10 * amount);
                else if (product == "sweets")
                    Console.WriteLine(1.35 * amount);
                else if (product == "peanuts")
                    Console.WriteLine(1.55 * amount);
            }
        }
    }
}
