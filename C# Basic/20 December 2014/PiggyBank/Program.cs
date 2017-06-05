using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = int.Parse(Console.ReadLine());
            var partyDays = int.Parse(Console.ReadLine());

            double monthlyVodka = partyDays * 5;
            double monthlySaved = (30 - partyDays) * 2;

            double monthlyMoney = monthlySaved - monthlyVodka;

            if(monthlyMoney < 0)
            {
                Console.WriteLine("never");
            }
            else
            {
                double timeNeeded = Math.Ceiling(price / monthlyMoney);
                Console.WriteLine($"{(int)timeNeeded / 12} years, {timeNeeded % 12} months");
            }
        }
    }
}
