using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            long startNum = long.Parse(Console.ReadLine());
            long endNum = long.Parse(Console.ReadLine());

            string primes = FindPrimesInRange(startNum, endNum);

            Console.WriteLine(primes);
        }

        static string FindPrimesInRange(long startNum, long endNum)
        {
            string primes = string.Empty;

            for (long i = startNum; i <= endNum; i++)
            {
                
                bool isPrime = IsPrime(i);
                if (isPrime)
                    primes += i + ", ";
            }
            primes = primes.Remove(primes.Length - 2);
            return primes;
        }

        private static bool IsPrime(long n)
        {
            if (n == 1) return false;
            if (n == 2) return true;

            if (n % 2 == 0) return false;

            for (long i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }

            return true;

        }
    }
    }

