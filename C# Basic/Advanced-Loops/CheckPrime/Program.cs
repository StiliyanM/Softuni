using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var prime = true;

            if(n < 2)
            {
                Console.WriteLine("Not Prime");
                return;
            }

            for (int i = 2; i < n - 1; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
                if(prime)
                    Console.WriteLine("Prime");
                else
                    Console.WriteLine("Not Prime");
            
        }
    }
}
