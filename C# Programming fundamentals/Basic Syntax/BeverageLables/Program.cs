using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLables
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());

            double energy = (double)energyContent / 100 * volume;
            double sugar = (double)sugarContent / 100 * volume;

            Console.WriteLine(volume + "ml " + name + ":");
            Console.WriteLine(energy + "kcal, " + sugar + "g sugars");
        }
    }
}
