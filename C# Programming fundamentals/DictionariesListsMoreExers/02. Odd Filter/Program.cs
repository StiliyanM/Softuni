using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var filtered = numbers.Where(x => x % 2 == 0).ToList();

            var final = filtered.Select(a => a > filtered.Average() ? ++a : --a).ToList();

            Console.WriteLine(string.Join(" ",final));

                
        }
    }
}
