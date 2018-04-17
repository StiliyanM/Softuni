using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Truck_Tour
{
    class Program
    {
        static void Main()
        {
            var petrolPumpsCount = int.Parse(Console.ReadLine());

            var queue = new Queue<int[]>();

            var fuel = 0;

            for (int i = 0; i < petrolPumpsCount; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                queue.Enqueue(input);
            }

            for (int currentStart = 0; currentStart < petrolPumpsCount - 1; currentStart++)
            {
                fuel = 0;

                var isSolution = true;
                for (int pumpsPassed = 0; pumpsPassed < petrolPumpsCount; pumpsPassed++)
                {
                    var petrolPump = queue.Dequeue();

                    var fuelAmount = petrolPump[0];
                    var distance = petrolPump[1];

                    queue.Enqueue(petrolPump);
                    fuel += fuelAmount - distance;
                    if(fuel < 0)
                    {
                        currentStart += pumpsPassed;
                        isSolution = false;
                        break;
                    }
                }
                if (isSolution)
                {
                    Console.WriteLine(currentStart);
                    return;
                }
            }
        }
    }
}
