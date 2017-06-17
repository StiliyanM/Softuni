using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(CountTrailingZeroes(factorial));
        }

        private static int CountTrailingZeroes(BigInteger n)
        {
            int trailingZeroesCnt = 0;

            for (int i = 0; i < n; i++)
            {
                if(n % 10 == 0)
                {
                    trailingZeroesCnt++;
                    n /= 10;
                }
                else
                {
                    return trailingZeroesCnt;
                }
            }
            return trailingZeroesCnt;
        }
    }
}
