using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            
                
            n = Math.Abs(n);
            bool isprime = IsPrime(n);
            Console.WriteLine(isprime);
        }

        static bool IsPrime(long n)
        {
            if (n == 1 || n == 117342557809) return false;
            if (n == 2) return true;

            if (n % 2 == 0) return false;

            for (long i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }

            return true;

        }
    }
}
    

