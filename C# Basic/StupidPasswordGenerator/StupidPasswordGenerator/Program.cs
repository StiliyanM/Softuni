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

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char o = 'a'; o < 'a' + l; o++)
                    {
                        for (char p = 'a'; p < 'a' + l; p++)
                        {
                            for (int x = Math.Max(i, j) + 1; x <= n; x++)
                            {
                                
                                Console.Write($"{i}{j}{o}{p}{x}");
                                Console.Write(" ");
                            }
                        }
                    }
                }
            }
        }
    }
}
