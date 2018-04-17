using System;
using System.Collections.Generic;

namespace _08._Recursive_Fibonacci
{
    class Program
    {
       private static Dictionary<int, long> cache = new Dictionary<int, long>();

        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(n)); 
        }

        private static long GetFibonacci(int n)
        {
            if(n == 1 || n == 2)
            {             
                return 1;
            }
            else
            {
                if (cache.ContainsKey(n))
                {
                    return cache[n];
                }
                else
                {
                    var result = GetFibonacci(n - 1) + GetFibonacci(n - 2);
                    cache[n] = result;
                    return result;
                }
            }
        }
    }
}
