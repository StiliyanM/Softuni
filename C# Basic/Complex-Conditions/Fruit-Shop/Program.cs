using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var amount = double.Parse(Console.ReadLine());

            if (day == "monday" || day == "tuesday" || day == "wednesday"
                || day == "thursday" || day == "friday")
            {
                if (fruit == "banana")
                    Console.WriteLine(Math.Round(2.50 * amount, 2));
                else if (fruit == "apple")
                    Console.WriteLine(Math.Round(1.20 * amount, 2));
                else if (fruit == "orange")
                    Console.WriteLine(Math.Round(0.85 * amount, 2));
                else if (fruit == "grapefruit")
                    Console.WriteLine(Math.Round(1.45 * amount, 2));
                else if (fruit == "kiwi")
                    Console.WriteLine(Math.Round(2.70 * amount, 2));
                else if (fruit == "pineapple")
                    Console.WriteLine(Math.Round(5.50 * amount, 2));
                else if (fruit == "grapes")
                    Console.WriteLine(Math.Round(3.85 * amount, 2));
                else
                    Console.WriteLine("error");
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                    Console.WriteLine(Math.Round(2.70 * amount, 2));
                else if (fruit == "apple")
                    Console.WriteLine(Math.Round(1.25 * amount, 2));
                else if (fruit == "orange")
                    Console.WriteLine(Math.Round(0.90 * amount, 2));
                else if (fruit == "grapefruit")
                    Console.WriteLine(Math.Round(1.60 * amount, 2));
                else if (fruit == "kiwi")
                    Console.WriteLine(Math.Round(3.00 * amount, 2));
                else if (fruit == "pineapple")
                    Console.WriteLine(Math.Round(5.60 * amount, 2));
                else if (fruit == "grapes")
                    Console.WriteLine(Math.Round(4.20 * amount, 2));
                else
                    Console.WriteLine("error");
            }
            else
                Console.WriteLine("error");
        }
    }
}
