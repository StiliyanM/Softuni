using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ').ToArray();
            int maxLength = int.Parse(Console.ReadLine());

            string[] addedIngredients = new string[10];
            int cnt = 0;
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == maxLength)
                {
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    addedIngredients[cnt] = ingredients[i];
                    cnt++;
                }
                if (cnt == 10)
                    break;
            }
            Console.WriteLine($"Made pizza with total of {cnt} ingredients.");
            Console.Write("The ingredients are: ");
            for (int i = 0; i < cnt; i++)
            {
                Console.Write(addedIngredients[i]);
                if(i != cnt - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(".");
        }
    }
}
