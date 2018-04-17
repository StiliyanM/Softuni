using System;
using System.Collections.Generic;
using System.Linq;
namespace P07PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameLength = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split().ToList();

            Action<List<string>, int> printOnlyLessOrEqualThen = (list, length) =>
            list.Where(e => e.Length <= length).ToList().ForEach(e => Console.WriteLine(e));

            printOnlyLessOrEqualThen(names,nameLength);
        }
    }
}
