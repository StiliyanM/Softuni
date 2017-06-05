using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = int.Parse(Console.ReadLine());
            var grape = double.Parse(Console.ReadLine());
            var litresWineNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            double wine = area * grape * 0.4 / 2.5;

            if(wine < litresWineNeeded)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",
                    Math.Floor(litresWineNeeded - wine));
            }
            else if(wine > litresWineNeeded)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",
                    Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.",
                    Math.Ceiling(wine - litresWineNeeded), Math.Ceiling((wine - litresWineNeeded) / workers));
            }
        }
    }
}
