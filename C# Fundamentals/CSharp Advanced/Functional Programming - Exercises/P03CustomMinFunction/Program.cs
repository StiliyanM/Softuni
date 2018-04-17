using System;
using System.Linq;

namespace P03CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> smallestNumber = numbers => numbers.Split(' ').Select(int.Parse).Min();

            Console.WriteLine(smallestNumber(Console.ReadLine()));
        }
    }
}
