using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());
            int sum = 0;
            int cnt = 0;
            for (int i = n; i > 0; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    sum += i * j * 3;
                    cnt++;
                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{cnt} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{cnt} combinations");
            Console.WriteLine($"Sum: {sum}");

        }
        }
    }

