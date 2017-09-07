using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            long steps = long.Parse(Console.ReadLine());
            long timeForEachStep = long.Parse(Console.ReadLine());

            long totalTimeInSecsNeeded = steps * timeForEachStep;

            int timeInSeconds = time[0] * 3600 + time[1] * 60 + time[2];

            long totalTime = timeInSeconds + totalTimeInSecsNeeded;
            long hours = totalTime / 3600;
            long minutes = (totalTime - hours * 3600) / 60;
            long seconds = (totalTime - hours * 3600 - minutes * 60);

            Console.WriteLine($"Time Arrival: {hours % 24:d2}:{minutes % 60:d2}:{seconds % 60:d2}");
            
        }
    }
}
