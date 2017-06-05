using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            minutes += 15;
            if (minutes > 60 && hours != 23)
            {
                hours++;
                minutes -= 60;
            }
            else if (hours == 23 && minutes > 60)
            {
                hours = 0;
                minutes -= 60;
            }
            else if(minutes == 60)
            {
                minutes = 0;
                hours++;
                if (hours == 24)
                    hours = 0;
            }
            if(minutes < 10)
                Console.WriteLine("{0}:0{1}", hours, minutes);
            else
                Console.WriteLine("{0}:{1}", hours, minutes);
        }
    }
}
