using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            int Symbol1 = 1;
            int Symbol2 = 1;
            string Symbol3 = "abcdefgh";
            string Symbol4 = "abcdefgh";
            int Symbol5 = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(Symbol1);
                Symbol1++;
                for (int k = 1; k <= n; k++)
                {
                    Console.Write(Symbol2);
                    Symbol2++;

                    for (int j = 0; j < l; j++)
                    {
                        Console.Write(Symbol3[j]);

                        for (int m = 0; m < l; m++)
                        {
                            Console.Write(Symbol4[l]);

                            for (int g = 1; g <= n; g++)
                            {
                                Console.Write(Symbol5);
                                Symbol5++;
                            }
                            Console.Write(" ");
                        }
                    }
                }
            }






        }
    }
}
