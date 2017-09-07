using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)

        {
            var pokePower = long.Parse(Console.ReadLine());
            var distanceBetweenTargets = long.Parse(Console.ReadLine());
            var exhaustionFactor = int.Parse(Console.ReadLine());

            var halfOfOriginalValue = pokePower / 2.0;

            var pokeCounter = 0;
            while (pokePower >= distanceBetweenTargets)
            {
                if(pokePower == halfOfOriginalValue)
                {
                    if (exhaustionFactor > 1)
                    {
                        pokePower /= exhaustionFactor;
                        continue;
                    }
                }
                    pokePower -= distanceBetweenTargets;
                    pokeCounter++;
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCounter);
        }
    }
}
