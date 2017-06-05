using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int first = n / 100;
            int second = (n / 10) % 10;
            int third = n % 10;

            int rows = first + second;
            int cols = first + third;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (n % 5 == 0)
                        n -= first;
                    else if (n % 3 == 0)
                        n -= second;
                    else
                        n += third;

                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
