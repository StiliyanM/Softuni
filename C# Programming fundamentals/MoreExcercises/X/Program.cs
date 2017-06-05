using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string(' ',i) + 'x' + new string(' ', (n - 2) - 2 * i) + 'x' + new string(' ', i));
            }

            Console.WriteLine(new string(' ', n / 2) + 'x') ;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string(' ', n / 2 - 1 - i) + 'x' + new string(' ', 1 + 2 * i) + 'x' + new string(' ', n / 2 - 1 - i));
            }
        }
    }
}
