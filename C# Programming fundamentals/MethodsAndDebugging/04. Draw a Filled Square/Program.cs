using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderFooter(n);

            PrintBody(n);
            
            PrintHeaderFooter(n);
        }

        private static void PrintBody(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");
                for (int j = 0; j < (n * 2 - 2) / 2; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }


        }

        private static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
    
}

