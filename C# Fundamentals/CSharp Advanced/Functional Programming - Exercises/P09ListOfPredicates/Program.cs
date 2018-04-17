using System;
using System.Collections.Generic;
using System.Linq;

namespace P09ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var endOfRange = int.Parse(Console.ReadLine());

            if(endOfRange < 0)
            {
                return;
            }

            var numbers = Enumerable.Range(1, endOfRange).ToList();

            var dividers = Console.ReadLine().Split()
                .Select(int.Parse)
                .Distinct()
                .OrderByDescending(d => d)
                .ToList();

            var filters = new List<Func<int, bool>>();

            foreach (var d in dividers)
            {
                filters.Add(GetFilter(d));
            }

            //numbers = numbers.Where(e => filters.All(f => f(e))).ToList();

            for (int i = 0; i < filters.Count; i++)
            {
                numbers = numbers.Where(filters[i]).ToList();
            }

            Console.WriteLine(string.Join(" ",numbers));
        }

        static Func<int, bool> GetFilter(int divisor)
        {
            return e => e % divisor == 0;
        }
    }
}
