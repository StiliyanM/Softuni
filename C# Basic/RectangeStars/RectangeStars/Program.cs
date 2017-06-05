using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangeStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            for(int x = 1; x <= n;x++)
            {
                for (int y = 1; y <= n; y++)
                {
                    if (x == 1 || x == n)
                        Console.Write("*");
                    else if (y == 1 || y == n)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
         }
      }
    }




