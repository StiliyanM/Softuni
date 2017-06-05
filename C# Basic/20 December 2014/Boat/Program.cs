using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            // first part sail

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine(new string('.', n - 1 - 2 * i) + new string('*', 1 + 2 * i) + new string('.', n)) ;
            }

            // second part sail 

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('.', 2 + 2 * i) + new string('*', n - 2 - 2 * i) + new string('.', n));
            }

            // boat

            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine(new string('.', i) + new string('*', 2 * n - 2 * i) + new string('.', i));
            }
        }
    }
}
