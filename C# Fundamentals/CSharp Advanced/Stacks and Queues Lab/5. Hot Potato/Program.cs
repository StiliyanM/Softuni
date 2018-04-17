using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _5._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = Regex.Split(Console.ReadLine(), @"\s");
            var toss = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(children);

            var counter = 1;
            while (queue.Count > 1)
            {
                if(counter != toss)
                {
                    queue.Enqueue(queue.Dequeue());
                    counter++;
                }
                else
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                    counter = 1;
                }
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
