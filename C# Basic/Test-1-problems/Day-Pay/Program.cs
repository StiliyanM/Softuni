using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Pay
{
    class Program
    {
        static void Main(string[] args)
        {
            var WorkDays = int.Parse(Console.ReadLine());
            var MoneyPerDay = double.Parse(Console.ReadLine());
            var rate = double.Parse(Console.ReadLine());

            double YearlySallary = WorkDays * 14.5 * MoneyPerDay * 0.75;
            double LevaPerDay = YearlySallary / 365 * rate;
            Console.WriteLine(Math.Round(LevaPerDay,2));
        }
    }
}
