using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = double.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());
            var dolls = int.Parse(Console.ReadLine());
            var bears = int.Parse(Console.ReadLine());
            var minions = int.Parse(Console.ReadLine());
            var trucks = int.Parse(Console.ReadLine());

            double money = p * 2.6 + dolls * 3 + bears * 4.10 + minions * 8.2 + trucks * 2;
            int count = p + dolls + bears + minions + trucks;

            if (count >= 50)
                money *= 0.75;

            money *= 0.9;

            double diff = money - price;

            if(diff >= 0)
                Console.WriteLine($"Yes! {diff:f2} lv left.");
            else
                Console.WriteLine($"Not enough money! {Math.Abs(diff):f2} lv needed.");

        }
    }
}
