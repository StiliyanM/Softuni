using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int middledashes = 0;

            if(n == 1)
            {
                Console.WriteLine("*");
                return;
            }
            if (n % 2 != 0)
            {
                middledashes++;
                Console.WriteLine(new string ('-', n/2) + '*' + new string('-', n / 2));
            }



            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('-', n / 2 - 1 - i));
                Console.Write("*");
                Console.Write(new string('-', 2 * i + middledashes));
                Console.Write("*");
                Console.WriteLine(new string('-', (n / 2 - 1) - i));
            }

            for (int i = n / 2 - 2; i >= 0; i--)
            {
                Console.Write(new string('-', n / 2 - 1 - i));
                Console.Write("*");
                Console.Write(new string('-', 2 * i + middledashes));
                Console.Write("*");
                Console.WriteLine(new string('-', (n / 2 - 1) - i));
            }
            if(n % 2 != 0)
                Console.WriteLine(new string('-', n / 2) + '*' + new string('-', n / 2));

        }
    }
}
