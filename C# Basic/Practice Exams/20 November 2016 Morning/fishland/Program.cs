using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var skumPrice = double.Parse(Console.ReadLine());
            var cacaPrice = double.Parse(Console.ReadLine());
            var palaKg = double.Parse(Console.ReadLine());
            var safKg = double.Parse(Console.ReadLine());
            var shellKg = double.Parse(Console.ReadLine());

            double palaPrice = 1.6 * skumPrice;
            double safPrice = 1.8 * cacaPrice;
            double shellPrice = 7.5;

            double moneyNeeded = palaKg * palaPrice + safKg * safPrice + shellKg * shellPrice;

            Console.WriteLine($"{moneyNeeded:f2}");
        }
    }
}
