using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;

            for (int i = 0; i <= 20; i++)
            {
                var ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {cnt} ingredients.");
                    return;

                }
                Console.WriteLine("Adding ingredient " + ingredient + '.');
                cnt++;
            }
        }
    }
}
