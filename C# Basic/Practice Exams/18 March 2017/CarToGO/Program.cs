using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarToGO
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            string Class = string.Empty;
            double price = 0;
            string type = string.Empty;

            if(budget <= 100)
            {
                Class = "Economy class";
                if(season == "Summer")
                {
                    type = "Cabrio";
                    price = 0.35 * budget;
                }
                else if(season == "Winter")
                {
                    type = "Jeep";
                    price = 0.65 * budget;
                }
            }
            else if(budget <= 500)
            {
                Class = "Compact class";
                if (season == "Summer")
                {
                    type = "Cabrio";
                    price = 0.45 * budget;
                }
                else if (season == "Winter")
                {
                    type = "Jeep";
                    price = 0.8 * budget;
                }
            }
            else
            {
                Class = "Luxury class";
                type = "Jeep";
                price = 0.9 * budget;
            }
            Console.WriteLine($"{Class}");
            Console.WriteLine($"{type} - {price:f2}");
        }
    }
}
