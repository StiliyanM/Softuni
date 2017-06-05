using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write("+");
            for (int i = 0; i < n-2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("|");
                for (int r = 0; r < n - 2; r++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }

            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
