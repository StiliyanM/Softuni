using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortress
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write("/" + new string('^', n / 2) + '\\');
            Console.Write(new string('_', 2 * n -(  n / 2 + n/2 + 4)));
            Console.WriteLine("/" + new string('^', n / 2) + '\\');

            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("|" + new string(' ', 2 * n - 2) + "|");
            }
            Console.WriteLine("|" + new string (' ', n /2 + 1) 
                + new string('_', 2 * n - (n / 2 + n / 2 + 4)) + new string(' ', n / 2 + 1) + '|');

            Console.Write("\\" + new string('_', n / 2) + '/');
            Console.Write(new string(' ', 2 * n - (n / 2 + n / 2 + 4)));
            Console.WriteLine("\\" + new string('_', n / 2) + '/');

        }
    }
}
