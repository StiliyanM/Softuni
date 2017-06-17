using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LIS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var LIS = FindLIS(numbers);

            Console.WriteLine(string.Join(" ", LIS));
        }

        private static int[] FindLIS(int[] numbers)
        {
            var len = new int[numbers.Length];
            var prev = new int[numbers.Length];

            var bestLen = 0;
            var lastIndex = -1;

            for (int anchor = 0; anchor < numbers.Length; anchor++)
            {
                len[anchor] = 1;
                prev[anchor] = -1;

                var anchorNum = numbers[anchor];
                for (int i = 0; i < anchor; i++)
                {
                    var currentNum = numbers[i];

                    if(currentNum < anchorNum && len[i] + 1 > len[anchor])
                    {
                        len[anchor] = len[i] + 1;
                        prev[anchor] = i;
                    }
                }

                if(len[anchor] > bestLen)
                {
                    bestLen = len[anchor];

                    lastIndex = anchor;
                }
            }

            var LIS = new List<int>();

            while (lastIndex != -1)
            {
                LIS.Add(numbers[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            LIS.Reverse();

            return LIS.ToArray();
        }
    }
}
