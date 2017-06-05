using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());

            int i = multiplier;
            do
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
                i++;
            }
            while (i <= 10);
        }
    }
}
