using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleStar
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            for(int x = 1; x <= n;x++)
            {
                for(int p = 1; p <= n; p++)
                {
                    if (x == 1 || x == n)
                        Console.Write("*");
                    else if (p == 1 || p == n)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
