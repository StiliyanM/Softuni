using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
           int result = GetMipltipleOfEvensAndOdds(n);

            Console.WriteLine(result);
        }

        static int GetMipltipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);

            return sumEvens * sumOdds;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            int digit = 0;

            while (n > 0)
            {
                digit = n % 10;
                if (digit % 2 != 0)
                    sum += digit;

                n = n / 10;
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            int digit = 0;

            while (n > 0)
            {
                digit = n % 10;
                if (digit % 2 == 0)
                    sum += digit;

                n = n / 10;
            }
            return sum;
        }
    }
}
