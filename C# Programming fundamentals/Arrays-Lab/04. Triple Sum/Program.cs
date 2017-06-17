using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();

            string[] items = values.Split(' ');

            long[] arr = items.Select(long.Parse).ToArray();

            long firstNum = 0;
            int cnt = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                firstNum = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    long pairSum = firstNum + arr[j];
                    
                    if (arr.Contains(pairSum))
                    {
                        Console.WriteLine($"{firstNum} + {arr[j]} == {pairSum}");
                        cnt++;
                    }
                }
            }

            if (cnt == 0)
                Console.WriteLine("No");

        }
    }
}
