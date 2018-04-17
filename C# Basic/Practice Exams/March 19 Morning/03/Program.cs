using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            string location = string.Empty;
            string place = string.Empty;
            double moneyNeeded = 0;

            if(budget <= 1000)
            {
                place = "Camp";
                if(season == "Summer")
                {
                    location = "Alaska";
                    moneyNeeded = budget * 0.65;
                }
                else
                {
                    location = "Morocco";
                    moneyNeeded = budget * 0.45;
                }
            }
            else if(budget <= 3000)
            {
                place = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    moneyNeeded = budget * 0.80;
                }
                else
                {
                    location = "Morocco";
                    moneyNeeded = budget * 0.60;
                }
            }
            else
            {
                place = "Hotel";
                if (season == "Summer")
                {
                    location = "Alaska";
                    moneyNeeded = budget * 0.9;
                }
                else
                {
                    location = "Morocco";
                    moneyNeeded = budget * 0.9;
                }
            }

            Console.WriteLine($"{location} - {place} - {moneyNeeded:f2}");
        }
    }
}
