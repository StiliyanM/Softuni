using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            // first 2 lines 

            Console.WriteLine(new string('*', 2 * n + 1));
            Console.WriteLine(".*" + new string(' ', 2 * n - 3) + "*.");

            // first middle half

            for (int i = 0; i < n - 2 ; i++)
            {
                Console.WriteLine(new string('.', 2 + i) + '*' + new string('@', 2 * n - 5 - 2 * i) + '*' + new string('.',2 + i));
            }

            // middle line

            Console.WriteLine(new string('.', n) + '*' + new string('.', n));

            // second middle half 

            for (int i = 0; i < n - 2; i++)
            {
                string dots = new string('.', n - 1 - i);

                Console.WriteLine(dots + '*' + new string(' ', i) + '@' + new string(' ', i) + '*' + dots);
            }



            // last 2 lines

            Console.WriteLine(".*" + new string('@', 2 * n - 3) + "*.");
            Console.WriteLine(new string('*', 2 * n + 1));

            
        }
    }
}
