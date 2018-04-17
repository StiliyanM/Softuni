using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            var cupsNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());

            int hours = workers * 8 * days;

            double cups = Math.Floor((double)hours / 5);

            double diff = cupsNeeded - cups;

            if(diff < 0)
                Console.WriteLine($"{Math.Abs(diff * 4.20):f2} extra money");
            else
                Console.WriteLine($"Losses: {diff * 4.20:f2}");
        }
    }
}
