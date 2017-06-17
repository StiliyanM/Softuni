using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productNames = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            
            while (true)
            {
                string names = Console.ReadLine();

                if(names == "done")
                {
                    break;
                }

                int index = Array.IndexOf(productNames, names);

                Console.WriteLine($"{names} costs: {price[index]}; Available quantity: {quantities[index]}");
            }
        }
    }
}
