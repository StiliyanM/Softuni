using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            int firstBoatDistance = 0;
            int secondBoatDistance = 0;

            for (int i = 1; i <= n; i++)
            {
                string str = Console.ReadLine();

                if (str != "UPGRADE")
                {
                    if (i % 2 != 0)
                    {
                        firstBoatDistance += str.Length;
                    }
                    else
                    {
                        secondBoatDistance += str.Length;
                    }
                }
                else
                {
                    firstBoat +=(char) 3;
                    secondBoat += (char) 3;
                }

                if(firstBoatDistance >= 50)
                {
                    Console.WriteLine(firstBoat);
                    return;
                }
                else if(secondBoatDistance >= 50)
                {
                    Console.WriteLine(secondBoat);
                    return;
                }
            }

            if(firstBoatDistance > secondBoatDistance)
            {
                Console.WriteLine(firstBoat);
            }
            else if(secondBoatDistance > firstBoatDistance)
            {
                Console.WriteLine(secondBoat);
            }
        }
    }
}
