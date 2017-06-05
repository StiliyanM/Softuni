using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var p = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            double GamesTotal = (48 - h) * 3 / 4 + p * 2 / 3 + h;

            if (year == "leap")
                GamesTotal += GamesTotal * 0.15;
            Console.WriteLine(Math.Floor(GamesTotal));
        }
    }
}
