using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Stack_Operations
{
    class Program
    {
        static void Main()
        {
            var args = Console.ReadLine().Split();

            var elementsToPushCount = int.Parse(args[0]);
            var elementsToPopCount = int.Parse(args[1]);
            var elementToPeek = int.Parse(args[2]);

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var stack = new Stack<int>();

            var pushCount = Math.Min(elementsToPushCount, numbers.Count);

            for (int i = 0; i < pushCount; i++)
            {
                stack.Push(numbers[i]);
            }

            var popCount = Math.Min(elementsToPopCount, stack.Count);

            for (int i = 0; i < popCount; i++)
            {
                stack.Pop();
            }

            if(stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            if (stack.Contains(elementToPeek))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }


        }
    }
}
