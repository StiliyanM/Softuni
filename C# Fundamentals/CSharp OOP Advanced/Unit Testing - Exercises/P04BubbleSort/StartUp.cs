using System;
using System.Linq;

namespace P04BubbleSort
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split().Select(int.Parse).ToList();

            Bubble.Sort(elements);

            Console.WriteLine(string.Join(" ",elements));
        }
    }
}
