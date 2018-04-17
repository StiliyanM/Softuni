using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Reverse_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var stack = new Stack<int>(numbers);

            var reversedNumbers = stack.ToArray();
            Console.WriteLine(string.Join(" ",reversedNumbers));
        }
    }
}
