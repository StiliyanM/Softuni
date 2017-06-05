using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int r = 1; r <= n; r++)
            {
                Console.Write('$');
                for (int c = 0; c < r - 1; c++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
