using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;
namespace P04CubicAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            var regionStatistics = new Dictionary<string, MeteorStatistics>();

            string input;

            while ((input = Console.ReadLine()) != "Count em all")
            {
                var tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                var regionName = tokens[0];
                var meteorType = tokens[1];
                var count = int.Parse(tokens[2]);

                if (!regionStatistics.ContainsKey(regionName))
                {
                    regionStatistics[regionName] = new MeteorStatistics();
                }

                switch (meteorType)
                {
                    case "Green":
                        if (count >= 1000000)
                        {
                            regionStatistics[regionName].RedMeteors += count / 1000000;
                            regionStatistics[regionName].GreenMeteors += count % 1000000;
                        }
                        else
                        {
                            regionStatistics[regionName].GreenMeteors += count;
                        }
                        break;
                    case "Red":
                        if (count >= 1000000)
                        {
                            regionStatistics[regionName].BlackMeteors += count / 1000000;
                            regionStatistics[regionName].RedMeteors += count % 1000000;
                        }
                        else
                        {
                            regionStatistics[regionName].RedMeteors += count;
                        }

                        break;
                    case "Black":
                        regionStatistics[regionName].BlackMeteors += count;
                        break;
                }

            }

            foreach (var region in regionStatistics)
            {
                var meteors = region.Value;

                if (meteors.GreenMeteors >= 1000000)
                {
                    meteors.RedMeteors += meteors.GreenMeteors / 1000000;
                    meteors.GreenMeteors = meteors.GreenMeteors % 1000000;
                }
                if (meteors.RedMeteors >= 1000000)
                {
                    meteors.BlackMeteors += meteors.RedMeteors / 1000000;
                    meteors.RedMeteors = meteors.RedMeteors % 1000000;
                }
            }

            foreach (var region in regionStatistics
                                    .OrderByDescending(e => e.Value.BlackMeteors)
                                    .ThenBy(e => e.Key.Length)
                                    .ThenBy(e => e.Key))
            {
                Console.WriteLine(region.Key);

                var meteors = region.Value;

                var statistics = new Dictionary<string, BigInteger>()
                {
                    { "Red", meteors.RedMeteors},
                    { "Green", meteors.GreenMeteors},
                     { "Black", meteors.BlackMeteors},
            };

                foreach (var m in statistics
                                     .OrderByDescending(e => e.Value)
                                     .ThenBy(e => e.Key))
                {
                    Console.WriteLine($"-> {m.Key} : {m.Value}");
                }
            }
        }
    }

    internal class MeteorStatistics
    {
        public BigInteger BlackMeteors { get; set; }
        public long RedMeteors { get; set; }
        public long GreenMeteors { get; set; }
    }
}
