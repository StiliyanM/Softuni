using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sleepy_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            var restDays = int.Parse(Console.ReadLine());
            int workDays = 365 - restDays;
            int playTime = workDays * 63 + restDays * 127;
            int difference = Math.Abs(30000 - playTime);
            int hours = difference / 60;
            int minutes = difference - hours * 60;

            if(playTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else if(playTime < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
        }

    }
}
