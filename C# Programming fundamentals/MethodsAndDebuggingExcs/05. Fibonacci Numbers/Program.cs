using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fib = GetFib(n);
            Console.WriteLine(fib);
        }

        static int GetFib(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            else
            {
                return GetFib(n - 1) + GetFib(n - 2);
            }
        }
    }
}
