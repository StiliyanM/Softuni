using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = int.Parse(Console.ReadLine());
            var chinese = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine());

            double euros = (bitcoins * 1168 / 1.95) + (chinese * 0.15 * 1.76 / 1.95);

            Console.WriteLine(euros - euros * commission / 100);
        }
    }
}
