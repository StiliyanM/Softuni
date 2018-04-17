using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var food = int.Parse(Console.ReadLine());
            var dog = double.Parse(Console.ReadLine());
            var cat = double.Parse(Console.ReadLine());
            var turtle = double.Parse(Console.ReadLine());

            double foodNeeded = days * (dog + cat + turtle / 1000);

            double diff = food - foodNeeded;

            if(diff < 0)
            {
                Console.WriteLine($"{Math.Ceiling(Math.Abs(diff))} more kilos of food are needed.");
            }
            else
                Console.WriteLine($"{Math.Floor(diff)} kilos of food left.");
        }
    }
}
