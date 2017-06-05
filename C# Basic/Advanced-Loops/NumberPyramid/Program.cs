using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            for (int r = 1; r <= n; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    if (c > 1) Console.Write(" ");
                    Console.Write(num);
                    num++;
                    if (num > n)
                        break;
                }
                Console.WriteLine();
                if (num > n)
                    break;

            }
        }
    }
}
