using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeNameStats = new Dictionary<string, SortedDictionary<string,List <long>>>();

            var typeAverages = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split().ToArray();

                string type = tokens[0];
                string name = tokens[1];

                List<long> stats = GetStats(tokens);

                if (!typeNameStats.ContainsKey(type) && !typeAverages.ContainsKey(type))
                {
                    typeNameStats[type] = new SortedDictionary<string, List<long>>();
                    typeAverages[type] = new List<decimal>() { 0m, 0.00m,0.00m,0.00m };
                }
                if(typeNameStats.ContainsKey(type) && typeNameStats[type].ContainsKey(name))
                {
                    typeNameStats[type][name] = stats;
                }


                if (!typeNameStats[type].ContainsKey(name))
                {
                    typeNameStats[type][name] = stats;
                    for (int j = 0; j < 3; j++)
                    {
                        typeAverages[type][j + 1] += typeNameStats[type][name][j];
                    }
                }

                typeAverages[type][0]++;
            }

            
            foreach (var type in typeNameStats)
            {
                var thetype = type.Key;
                var nameStats = type.Value;
                var average = typeAverages[thetype].Select(x => x / typeAverages[thetype][0]).ToList();

                Console.WriteLine($"{thetype}::({average[1]}/{average[2]}/{average[3]})");


                foreach (var name in nameStats)
                {
                    var theName = name.Key;
                    var theStats = name.Value;

                    Console.WriteLine($"-{theName} -> damage: {theStats[0]}, health: {theStats[1]}, armor: {theStats[2]}");
                }
            }

        }

        private static List<long> GetStats(string[] tokens)
        {
            long damage = 0;
            long health = 0;
            long armor = 0;

            if (tokens[2] == "null")
            {
                damage = 45;
            }
            else
            {
                damage = long.Parse(tokens[2]);
            }
            if (tokens[3] == "null")
            {
                health = 250;
            }
            else
            {
                health = long.Parse(tokens[3]);
            }
            if (tokens[4] == "null")
            {
                armor = 10;
            }
            else
            {
                armor = long.Parse(tokens[4]);
            }

            var stats = new List<long>();

            stats.Add(damage);
            stats.Add(health);
            stats.Add(armor);

            return stats;
        }
    }
}
