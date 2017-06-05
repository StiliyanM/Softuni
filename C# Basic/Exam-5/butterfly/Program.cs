using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string middle = "\\ /";
            char special = '*';
            string middle2 = "/ \\";
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 != 0)
                    special = '-';

                Console.WriteLine(new string(special, n -2) + middle + new string(special, n - 2));

                special = '*';
            }

            Console.WriteLine(new string(' ',n - 1) + '@');

            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 != 0)
                    special = '-';

                Console.WriteLine(new string(special, n - 2) + middle2 + new string(special, n - 2));

                special = '*';
            }
        }
    }
}
