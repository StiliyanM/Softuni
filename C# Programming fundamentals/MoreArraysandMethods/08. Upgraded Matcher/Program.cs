using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productNames = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            long quantitiesLeft = 0;

            while (true)
            {
                string[] names = Console.ReadLine().Split(' ').ToArray();

                if (names[0] == "done")
                {
                    break;
                }

                int index = Array.IndexOf(productNames, names[0]);

               int quantitiesNeeded = int.Parse(names[1]);

                int quantitiesIndex = quantities.Length;
                if (index < quantitiesIndex)
                {
                    quantitiesLeft = quantities[index];

                }
                else
                {
                    quantitiesLeft = 0;
                }
               

                if (quantitiesNeeded > quantitiesLeft)
                {
                    Console.WriteLine($"We do not have enough {names[0]}");
                }
                else
                {
                    Console.WriteLine($"{names[0]} x {quantitiesNeeded} costs {quantitiesNeeded * price[index]:f2}");
                    quantities[index] -= quantitiesNeeded;
                    if (quantities[index] < 0)
                        quantities[index] = 0;
                }

            }
        }
    }
}
