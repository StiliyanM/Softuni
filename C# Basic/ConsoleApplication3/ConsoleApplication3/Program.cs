using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinute = int.Parse(Console.ReadLine());
            var arrivalHour = int.Parse(Console.ReadLine());
            var arrivalMinute = int.Parse(Console.ReadLine());

            int examMinutes = examHour * 60 + examMinute;
            int arrivalMinutes = arrivalHour * 60 + arrivalMinute;

            int diff = arrivalMinutes - examMinutes;
            int h = Math.Abs(diff / 60);
            int m = Math.Abs(diff % 60);
            if(diff > 0)
            {
                Console.WriteLine("Late");
                if(diff > 60)
                    Console.WriteLine($"{h}:{m:00} hours after the start");
                else
                    Console.WriteLine($"{m} minutes after the start");
            }
            else if(diff <= 0 && diff >= -30)
            {
                
                Console.WriteLine("On time");
                if(diff != 0)
                    Console.WriteLine($"{m} minutes before the start");
            }
            else if(diff < - 30)
            {
                Console.WriteLine("Early");
                if(diff > -60)
                    Console.WriteLine($"{m} minutes before the start");
                else
                    Console.WriteLine($"{h}:{m:00} hours before the start");
            }
            }
        }
}
