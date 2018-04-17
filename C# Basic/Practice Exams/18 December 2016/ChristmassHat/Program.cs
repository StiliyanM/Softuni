using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmassHat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            // Top

            Console.WriteLine(new string('.',2 * n - 1) + "/|\\" + new string('.', 2 * n - 1));
            Console.WriteLine(new string('.', 2 * n - 1) + "\\|/" + new string('.', 2 * n - 1));

            // rest
            for (int i = 0; i < 2 * n; i++)
            {
                char star = '*';
                string dots = new string('.', 2 * n - 1 - i);
                string minus = new string('-', i);

                Console.WriteLine(dots + star + minus + star + minus + star + dots);
            }
            // Bottom

            Console.WriteLine(new string('*', 4 * n + 1));
            for (int i = 0; i < 2 * n; i++)
            {
                   Console.Write("*.");
            }
            Console.WriteLine('*');
            Console.WriteLine(new string('*', 4 * n + 1));


        }
    }
}
