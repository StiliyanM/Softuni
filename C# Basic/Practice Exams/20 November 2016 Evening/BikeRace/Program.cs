using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            var type = Console.ReadLine();

            double Price = 0;
            double juniorsPrice = 0;
            double seniorsPrice = 0;
            if(type == "trail")
            {
                juniorsPrice = 5.5 * juniors;
                seniorsPrice = 7 * seniors;
            }
            else if (type == "cross-country")
            {
                juniorsPrice = 8 * juniors;
                seniorsPrice = 9.5 * seniors;
                if (seniors + juniors >= 50)
                {
                    juniorsPrice *= 0.75;
                    seniorsPrice *= 0.75;
                }

            }
            else if (type == "downhill")
            {
                juniorsPrice = 12.25 * juniors;
                seniorsPrice = 13.75 * seniors;
            }
            else if (type == "road")
            {
                juniorsPrice = 20 * juniors;
                seniorsPrice = 21.5 * seniors;
            }

            Price = juniorsPrice + seniorsPrice;
            Price *= 0.95;

            Console.WriteLine($"{Price:f2}");
        }
    }
}
