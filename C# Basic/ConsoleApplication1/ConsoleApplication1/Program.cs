using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int row = 0; row<= 10;row++)
            {
                Console.Write("");

                for(int col = 0; col <= row; col++)
                {
                    Console.Write("*");
                    Console.Write("");
                    Console.WriteLine();
                }

            }
        }
    }
}
