using System;
using System.Collections.Generic;

namespace _6._Traffic_Jam
{
    class Program
    {
        static void Main()
        {
            var carsThatCanPassCount = int.Parse(Console.ReadLine());

            var command = Console.ReadLine();

            var queue = new Queue<string>();

            var carsCounter = 0;
            while (command != "end")
            {
                if(command == "green")
                {
                    var carsToPass = Math.Min(queue.Count, carsThatCanPassCount);

                    for (int i = 0; i < carsToPass; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        carsCounter++;
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{carsCounter} cars passed the crossroads.");
        }
    }
}
