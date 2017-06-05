using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string left = "//";
            string right = "\\\\";

            Console.WriteLine(new string('.', n + 1)    // first line
                + new string('_', 2 * n + 1)
                + new string('.', n + 1)) ;         

            for (int i = 0; i < n + 1; i++)
            {
                string underline = new string('-', 2 * n - 1 + 2 * i);

                if( i == n)
                {
                    underline = new string('-', (2 * n - 1 + 2 * i - 5) / 2) + "STOP!"
                        + new string('-', (2 * n - 1 + 2 * i - 5) / 2);
                }
                Console.Write(new string('.', n - i)); // dots
                Console.Write(left);
                Console.Write(underline); // underlines 
                Console.Write(right);
                Console.WriteLine(new string('.', n - i)); // dots

            }

           

            for (int i = n; i > 0; i--)
            {
                Console.Write(new string('.', n - i)); // dots
                Console.Write(right);
                Console.Write(new string('-', 2 * n - 1 + 2 * i)); // underlines 
                Console.Write(left);
                Console.WriteLine(new string('.', n - i)); // dots

            }

        }
    }
}
