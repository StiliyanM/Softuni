using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            double aparment = 0.0;
            double studio = 0.0;
            if (month == "May" || month == "October")
            {
                studio = 50 * nights;
                aparment = 65 * nights;
                if (nights > 7)
                    studio = 0.95 * studio;
                else if (nights > 14)
                {
                    aparment -= aparment * 0.1;
                    studio = 0.70 * studio;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20 * nights;
                aparment = 68.70 * nights;
                if (nights > 14)
                {
                    studio *= 0.8;
                    aparment *= 0.9;
                }
            }
            else if (month == "July" || month == "August")
            {
                studio = 76 * nights;
                aparment = 77 * nights; 
                if (nights > 14)
                    aparment *= 0.9;
            }
            Console.WriteLine("Apartment: {0:f2} lv", aparment);
            Console.WriteLine("Studio: {0:f2} lv", studio);
        }
    }
}
