using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            int avgLaps = int.Parse(Console.ReadLine());
            int lapLength = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            long runnersTotal = Math.Min(runners, (long)trackCapacity * days);

            long meters = runnersTotal * (long)avgLaps * lapLength;
            long kms = meters / 1000;

            Console.WriteLine($"Money raised: {moneyPerKm * kms:f2}");


        }
    }
}
