using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var count = int.Parse(Console.ReadLine());

            double total = 0;
            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                var price = double.Parse(Console.ReadLine());
                var itemCnt = int.Parse(Console.ReadLine());

                if (itemCnt > 1)
                    name = name.Insert(name.Length, "s");

                Console.WriteLine($"Adding {itemCnt} {name} to cart.");

                budget -= price * itemCnt;
                total += price * itemCnt;

            }

            Console.WriteLine($"Subtotal: ${total:f2}");

            if(budget >= 0)
            {
                Console.WriteLine($"Money left: ${budget:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(budget):f2} more.");
            }
        }
    }
}
