using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var hornetsSummedUpPower = hornets.Sum();

            int hornetIndex = 0;
            for (int i = 0; i < beehives.Length; i++)
            {
            
                if(hornetsSummedUpPower > beehives[i])
                {
                    beehives[i] = 0;
                }
                else if(beehives[i] >= hornetsSummedUpPower)
                {
                    beehives[i] -= hornetsSummedUpPower;
                    hornetsSummedUpPower -= hornets[hornetIndex];
                    hornets[hornetIndex] = 0;
                    hornetIndex++;
                }

                if (hornetsSummedUpPower <= 0)
                {
                    break;
                }
            }

            beehives = beehives.Where(x => x > 0).ToArray();
            hornets = hornets.Where(x => x > 0).ToArray();

            var result = "";
            if(beehives.Length == 0)
            {
                result = string.Join(" ", hornets);
            }
            else
            {
                result = string.Join(" ", beehives);
            }

            Console.WriteLine(result);
        }
    }
}
