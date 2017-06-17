using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {

            var virusTimeToDefeat = new Dictionary<string, int>();
            double health = double.Parse(Console.ReadLine());

            double maxHealth = health;
            while (true)
            {
                var virusName = Console.ReadLine();

                if(virusName == "end")
                {
                    Console.WriteLine($"Final Health: {(int)health}");
                    break;
                }

                int strength = virusName.Sum(x => (int)x) / 3;

                int secondsToDefeat = strength * virusName.Length;
                if(!virusTimeToDefeat.ContainsKey(virusName))
                {
                    virusTimeToDefeat[virusName] = secondsToDefeat;
                }
                else
                {
                    virusTimeToDefeat[virusName] = secondsToDefeat / 3;
                }

                secondsToDefeat = virusTimeToDefeat[virusName];

                if(health >= secondsToDefeat)
                {
                    health -= secondsToDefeat;
                    Console.WriteLine($"Virus {virusName}: {strength} => {secondsToDefeat} seconds");
                    Console.WriteLine($"{virusName} defeated in {secondsToDefeat / 60}m {secondsToDefeat % 60}s.");
                    Console.WriteLine($"Remaining health: {health}");
                    health = Math.Floor(health * 1.2);
                    if (health > maxHealth)
                        health = maxHealth;
                }
                else
                {
                    Console.WriteLine($"Virus {virusName}: {strength} => {secondsToDefeat} seconds");
                    Console.WriteLine($"Immune System Defeated.");
                    return;
                }

                
            }
        }
    }
}
