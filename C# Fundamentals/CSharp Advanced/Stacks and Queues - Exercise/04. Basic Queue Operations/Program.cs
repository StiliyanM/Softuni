using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
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

            var queue = new Queue<int>();

            var pushCount = Math.Min(elementsToPushCount, numbers.Count);

            for (int i = 0; i < pushCount; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            var popCount = Math.Min(elementsToPopCount, queue.Count);

            for (int i = 0; i < popCount; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            if (queue.Contains(elementToPeek))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }


        }
    }
}
