using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var pDmg = int.Parse(Console.ReadLine());
            var gDmg = int.Parse(Console.ReadLine());

            int pCurrentHealth = 100;
            int gCurrentHealth = 100;
            int cnt = 0;
            int i = 1;
            while (true)
            {
                

                if (i % 2 != 0)
                {
                    gCurrentHealth -= pDmg;
                }
                else
                {
                    pCurrentHealth -= gDmg;
                }

                cnt++;

                if (gCurrentHealth <= 0)
                {
                    Console.WriteLine($"Pesho won in {cnt}th round.");
                    return;
                }
                else if(pCurrentHealth <= 0)
                {
                    Console.WriteLine($"Gosho won in {cnt}th round.");
                    return;
                }
                if (i % 2 != 0)
                {
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {gCurrentHealth} health.");
                }
                else
                {
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {pCurrentHealth} health.");
                }

                if(i % 3 == 0)
                {
                    gCurrentHealth += 10;
                    pCurrentHealth += 10;
                }

                i++;

            }
        }
    }
}
