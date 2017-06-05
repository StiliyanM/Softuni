using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            double greenNeeded = 2 * x * x - 1.2 * 2 + 2 * x * y - 2 * 1.5 * 1.5;
            double redNeeded = 2 * x * y + 2 * x * h / 2;

            double greenLiters = greenNeeded / 3.4;
            double redLiters = redNeeded / 4.3;

            Console.WriteLine($"{greenLiters:f2}");
            Console.WriteLine($"{redLiters:f2}");
        }
    }
}
