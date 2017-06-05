using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string spaces = new string(' ', n);
            string middlerow = '*' + new string('/', 2 * n - 2) + '*';
            Console.WriteLine(new string('*', n * 2) + spaces + new string('*', n * 2));

            for (int i = 0; i < n - 2; i++)
            {
                
                if (i == (n - 1) / 2 - 1)
                    spaces = new string('|', n);
                Console.WriteLine(middlerow + spaces + middlerow);
                spaces = new string(' ', n);
            }

            Console.WriteLine(new string('*', n * 2) + spaces + new string('*', n * 2));
        }
    }
}
