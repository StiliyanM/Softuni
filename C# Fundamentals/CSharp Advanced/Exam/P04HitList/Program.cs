using System;
using System.Linq;
using System.Collections.Generic;
namespace P04HitList
{
    class Program
    {
        static void Main()
        {
            var targetInfoIndex = int.Parse(Console.ReadLine());

            var people = new Dictionary<string, Dictionary<string, string>>();

            string input;
            while ((input = Console.ReadLine()) != "end transmissions")
            {                
                var tokens = input.Split('=');
                var name = tokens.First();
                var keyValuePairs = tokens[1].Split(';');

                if (!people.ContainsKey(name))
                {
                    people[name] = new Dictionary<string, string>();
                }

                for (int i = 0; i < keyValuePairs.Length; i++)
                {
                    var args = keyValuePairs[i].Split(':');

                    var key = args[0];
                    var value = args[1];

                    people[name][key] = value;
                }
            }

            var output = Console.ReadLine().Split();

            var personToKill = output[1];

            var infoIndex = 0;

            Console.WriteLine($"Info on {personToKill}:");

            foreach (var pair in people[personToKill].OrderBy(p => p.Key))
            {
                Console.WriteLine($"---{pair.Key}: {pair.Value}");

                infoIndex += pair.Key.Length + pair.Value.Length;
            }

            Console.WriteLine($"Info index: {infoIndex}");

            var diff = infoIndex - targetInfoIndex;

            if(diff >= 0)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                Console.WriteLine($"Need {Math.Abs(diff)} more info.");
            }
        }
    }
}
