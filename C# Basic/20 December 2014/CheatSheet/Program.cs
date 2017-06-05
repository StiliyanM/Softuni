using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheet
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            var V = long.Parse(Console.ReadLine());
            var H = long.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0;j < columns; j++)
                {
                    Console.Write(V * H);
                    if (j != columns - 1)
                        Console.Write(" ");
                    H++;
                }
                H -= columns;
                Console.WriteLine();
                V++;
            }
        }
    }
}
