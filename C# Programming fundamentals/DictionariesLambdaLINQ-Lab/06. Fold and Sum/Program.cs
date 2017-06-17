using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int k = nums.Count / 4;

            var row1Left = nums.Take(k).Reverse().ToList();
            var row2Left = nums.Skip(3 * k).Reverse().ToList();

            var row1 = row1Left.Concat(row2Left).ToArray();

            var row2 = nums.Skip(k).Take(2 * k).ToArray();

            var sum = new int[2 * k];

            for (int i = 0; i < 2 * k; i++)
            {
                sum[i] = row1[i] + row2[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
