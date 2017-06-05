using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                string part = '*' + new string('.',1 + i) + '*';
                string midd = '*' + new string('.', 1 + 2 * i) + '*';
                string space = new string(' ', n - 3 - 2 * i);

                if (i == n / 2 - 1)
                    midd = new string('*', (n - 4) / 2) + '.' + new string('*', (n - 4) / 2);
                Console.WriteLine(part + space + midd + space + part);
                
        }
        }
    }
}
