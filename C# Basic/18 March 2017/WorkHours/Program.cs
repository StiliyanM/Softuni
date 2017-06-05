using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());

            int hours = workers * days * 8;
            int diff = hours - hoursNeeded;

            int penatlies = Math.Abs(diff * days);

            if (diff > 0)
            {
                Console.WriteLine($"{diff} hours left");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(diff)} overtime");
                Console.WriteLine($"Penalties: { penatlies }");
            }

        }
    }
}
