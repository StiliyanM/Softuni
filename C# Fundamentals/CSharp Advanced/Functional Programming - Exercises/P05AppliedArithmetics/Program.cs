using System;
using System.Collections.Generic;
using System.Linq;
namespace P05AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<List<int>,List<int>> add = collection =>
            collection = collection.Select(n => n = n + 1).ToList();
            Func<List<int>, List<int>> muliply = collection =>
            collection = collection.Select(n => n *= 2).ToList();
            Func<List<int>, List<int>> subtract = collection =>
            collection = collection.Select(n => n -= 1).ToList();
            Action<List<int>> print = collection => Console.WriteLine(string.Join(" ",collection));

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = add(numbers);
                        break;
                    case "multiply":
                        numbers = muliply(numbers);
                        break;
                    case "subtract":
                        numbers = subtract(numbers);
                        break;
                    case "print":
                        print(numbers);
                        break;
                }
            }


        }
    }
}
