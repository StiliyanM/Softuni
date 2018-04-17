using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            // first part 
            int i = 0;
            while (6 * n - 3 - 3 * i >= 0)
            {
                Console.WriteLine(new string('.', 6 * n - 3 - 3 * i) + new string('#', 1 + 6 * i) + new string('.', 6 * n - 3  - 3 * i));
                i++;
            }

            // second part

            char special = '|';
            for (int j = 0; j < n - 2; j++)
            {
                Console.WriteLine(special + new string('.', 2 + 3 * j) + new string('#',12 * n - 11 - 6 * j) + new string('.', 3 + 3 * j));
            }

            // third part

            for (int j = 0; j < n; j++)
            {
                if (j == n - 1)
                    special = '@';
                Console.WriteLine(special + new string('.', 3 * n - 4) + new string('#', 6 * n + 1) + new string('.', 3 * n - 3));
            }
        }
    }
}
