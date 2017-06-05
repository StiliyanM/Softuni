using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;
            int diff = 0;

            for(int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                    evenSum += num;
                else
                    oddSum += num;
            }

            diff = Math.Abs(evenSum - oddSum);

            if (diff == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
