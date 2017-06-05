using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            double timeInHours = hours + minutes / 60 + seconds / 3600;
            double timeInSecs = timeInHours * 3600;

            double kilometres = meters / 1000;
            double miles = meters / 1609;

            double metersPerSecond = meters / timeInSecs;
            double kmPerHour = kilometres / timeInHours;
            double MPerHour = miles / timeInHours;

            Console.WriteLine($"{(float)metersPerSecond}");
            Console.WriteLine($"{(float)kmPerHour}");
            Console.WriteLine($"{(float)MPerHour}");

        }
    }
}
