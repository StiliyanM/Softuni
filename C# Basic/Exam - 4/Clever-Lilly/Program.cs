using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clever_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var X = double.Parse(Console.ReadLine());
            var P = int.Parse(Console.ReadLine());

            int OddCounter = 0;
            int EvenCounter = 0;

            int money = 0;
            int overallMoney = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                    OddCounter++;
                else
                {
                    EvenCounter++;
                    money += EvenCounter * 10 - 1;
                }
            }
            overallMoney = money + OddCounter * P;
            double diff = (double) overallMoney - X;

            if(diff >= 0)
                Console.WriteLine("Yes! {0:F2}", diff);
            else
                Console.WriteLine("No! {0:f2}", Math.Abs(diff));


        }
    }
}
