using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            // first part

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', (3 * n - 2) / 2 - i) + '/' + new string(' ', i)
                    + new string(' ', i) + '\\' + new string('.', (3 * n - 2) / 2 - i)) ;
            }
            Console.WriteLine(new string('.', n / 2) + new string('*', 2 * n) + new string('.', n / 2));

            // second part

            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine(new string('.', n / 2) + '|' + new string('\\', 2 * n - 2)
                    + '|' + new string('.', n / 2));
            }

            // end

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('.', n / 2 - i) + '/' + new string('*', 2 * n - 2 + 2 * i)
                    + '\\' + new string('.', n / 2 - i));
            }
        }
    }
}
