using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingsFlapsCount = int.Parse(Console.ReadLine());
            double metersFor1000flaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distance = (wingsFlapsCount / 1000.0) * metersFor1000flaps;

            int timeNeeded = (int)(wingsFlapsCount / 100.0);
            int restTime = (wingsFlapsCount / endurance) * 5;
            
            timeNeeded += restTime;
            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{timeNeeded} s.");
        }
    }
}
