using System;
using System.Collections.Generic;
using System.Linq;

namespace P04FindEvensorOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var bounds = Console.ReadLine().Split().Select(int.Parse).ToList();
            var lower = bounds[0];
            var upper = bounds[1];

            var numbers = Enumerable.Range(lower, upper - lower + 1).ToList();

            var evenOrOdd = Console.ReadLine();

            Action<Func<int,bool>,List<int>> PrintOddOrEven = (isEvenOrOdd, numbersArray) =>
            Console.WriteLine(string.Join(" ",numbersArray.Where(isEvenOrOdd)));

                PrintOddOrEven(GetFilter(evenOrOdd), numbers);
        }

        private static Func<int,bool> GetFilter(string evenOrOdd)
        {
            if(evenOrOdd == "even")
            {
                return e => e % 2 == 0;
            }
            else
            {
                return e => e % 2 == 0;
            }
        }
    }
}
