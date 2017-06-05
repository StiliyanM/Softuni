using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            // first 2

            Console.WriteLine('@' + new string(' ', n - 2) + '@' + new string(' ', n - 2) + '@');
            Console.WriteLine("**" + new string(' ', n - 3) + '*' + new string(' ', n - 3)+ "**") ;
            // first half

            for (int i = 0; i < n / 2 - 1; i++)
            {
                int number = n - 5 -  2 * i;
                if (number < 0)
                    number = 0;
                string part = '*' + new string('.',1 + i) + '*';
                string space = new string(' ', number);
                string middle = '*' + new string('.', 1 + 2 * i) + '*';
                if (i == n / 2 - 2)
                    middle = new string('.', 1 + 2 * i);
                Console.WriteLine(part + space + middle + space + part);

            }

            Console.WriteLine('*' + new string('.', n / 2) + new string('*', n / 2 - 2) + '.'
                + new string('*', n / 2 - 2) + new string('.', n / 2) + '*');

            Console.WriteLine(new string('*', 2 * n - 1));
            Console.WriteLine(new string('*', 2 * n - 1));

        }
    }
}
