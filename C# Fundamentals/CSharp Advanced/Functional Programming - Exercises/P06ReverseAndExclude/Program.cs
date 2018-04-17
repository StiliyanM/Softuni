using System;
using System.Collections.Generic;
using System.Linq;

namespace P06ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var divisor = Console.ReadLine();
            Action<List<int>> reverse = collection => collection.Reverse();

            Func<List<int>, string, List<int>> exclude = (collection, filter) =>
             collection = collection.Where(GetFilter(filter)).ToList();

            Action<List<int>> print = collection => Console.WriteLine(string.Join(" ", collection));

            reverse(numbers);
            numbers = exclude(numbers, divisor);
            print(numbers);
        }

        static Func<int,bool> GetFilter(string condition)
        {
            var divisor = int.Parse(condition);

            return e => e % divisor != 0;
        }
    }
}
