using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var OddFirst = double.Parse(Console.ReadLine());
            var EvenFirst = double.Parse(Console.ReadLine());

            double OddSum = OddFirst;
            double OddMin = -1;
            double OddMax = 1;
            double EvenSum = EvenFirst;
            double EvenMin = -1;
            double EvenMax = 1;


            for (int i = 1; i <= n - 2; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if(i % 2 != 0)
                {
                    OddSum += num;
                    if (num > OddFirst)
                        OddMax = num;
                    if (OddFirst > num)
                        OddMin = num;
                }

                if(i % 2 == 0)
                {
                    
                }
            }

            Console.WriteLine(OddSum);
            Console.WriteLine(OddMin);
            Console.WriteLine(OddMax);
        }
    }
}