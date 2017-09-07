using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            var legionsWithActivity = new Dictionary<string, int>();
            var legionsWithSoldiers = new Dictionary<string, Dictionary<string,long>>();

            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var inputMatch =
                Regex.Match(input, @"(?<activity>[0-9]+) = (?<legion>.*) -> (?<type>.*):(?<count>[0-9]+)");

                var legionName = inputMatch.Groups["legion"].Value;
                var activity = int.Parse(inputMatch.Groups["activity"].Value);
                var soldierType = inputMatch.Groups["type"].Value;
                long soldierCount = long.Parse(inputMatch.Groups["count"].Value);

                if (!legionsWithActivity.ContainsKey(legionName))
                {
                    legionsWithActivity[legionName] = activity;
                    legionsWithSoldiers[legionName] = new Dictionary<string, long>();
                }

                if(!legionsWithSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionsWithSoldiers[legionName][soldierType] = 0;
                }

                legionsWithSoldiers[legionName][soldierType] += soldierCount;

                if(legionsWithActivity[legionName] < activity)
                {
                    legionsWithActivity[legionName] = activity; 
                }
            }

            var outputInput = Console.ReadLine().Split('\\');

            if(outputInput.Length > 1)
            {
                var activity = int.Parse(outputInput[0]);
                var soldierType = outputInput[1];
                
                foreach (var ls in legionsWithSoldiers.
                    Where(legion => legion.Value.ContainsKey(soldierType)).
                    OrderByDescending(legion => legion.Value[soldierType]))
                {
                    if (activity > legionsWithActivity[ls.Key])
                    {
                        Console.WriteLine($"{ls.Key} -> {ls.Value[soldierType]}");
                    }
                }
            }
            else
            {
                var soldierType = outputInput[0];

                foreach (var la in legionsWithActivity.OrderByDescending(legion => legion.Value))
                {
                    if(legionsWithSoldiers[la.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{la.Value} : {la.Key}");
                    }
                }
            }
        }
    }
}
