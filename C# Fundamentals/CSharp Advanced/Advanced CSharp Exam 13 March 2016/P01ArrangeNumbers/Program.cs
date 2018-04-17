using System;
using System.Linq;

namespace P01ArrangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ints = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            Console.WriteLine(string.Join(", ", Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(str => string.Join(string.Empty, str.Select(ch => ints[ch - '0'])))));
        }
    }
}
