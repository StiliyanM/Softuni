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
            var season = Console.ReadLine();
            var type = Console.ReadLine();
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());

            string sport = string.Empty;
            double priceForNight = 0;
            if(type == "boys" || type == "girls")
            {
                if(season == "Winter")
                {
                    priceForNight = students * 9.6;
                }
                else if(season == "Spring")
                {
                    priceForNight = students * 7.2;
                }
                else if(season == "Summer")
                {
                    priceForNight = students * 15;
                }
            }
            else if(type == "mixed")
            {
                if (season == "Winter")
                {
                    priceForNight = students * 10;
                }
                else if (season == "Spring")
                {
                    priceForNight = students * 9.5;
                }
                else if (season == "Summer")
                {
                    priceForNight = students * 20;
                }
            }

            if (students >= 50)
                priceForNight /= 2;
            else if (students >= 20)
                priceForNight *= 0.85;
            else if (students >= 10)
                priceForNight *= 0.95;

            if (type == "girls")
            {
                if (season == "Winter")
                {
                    sport = "Gymnastics";
                }
                else if (season == "Spring")
                {
                    sport = "Athletics";
                }
                else if (season == "Summer")
                {
                    sport = "Volleyball";
                }
            }
            else if (type == "boys")
            {
                if (season == "Winter")
                {
                    sport = "Judo";
                }
                else if (season == "Spring")
                {
                    sport = "Tennis";
                }
                else if (season == "Summer")
                {
                    sport = "Football";
                }
            }
            else if (type == "mixed")
            {
                if (season == "Winter")
                {
                    sport = "Ski";
                }
                else if (season == "Spring")
                {
                    sport = "Cycling";
                }
                else if (season == "Summer")
                {
                    sport = "Swimming";
                }
            }

            Console.WriteLine($"{sport} {priceForNight * nights:f2} lv.");
        }
    }
}
