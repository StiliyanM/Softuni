using System;
using System.Collections.Generic;
using System.Linq;
namespace P01KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            var bulletPrice = int.Parse(Console.ReadLine());
            var gunBarrelSize = int.Parse(Console.ReadLine());

            var bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var intelligence = int.Parse(Console.ReadLine());

            var bulletCount = 0;

            while (true)
            {
                if(bullets.Count == 0)
                {
                    break;
                }
                if (locks.Count == 0)
                {
                    break;
                }
                var bullet = bullets.Pop();
                
                var @lock = locks.Peek();

                bulletCount++;
                intelligence -= bulletPrice;

                if(bullet <= @lock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (bulletCount == gunBarrelSize)
                {
                    if(bullets.Count >= 1)
                    Console.WriteLine("Reloading!");
                    bulletCount = 0;
                }

            }

            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
