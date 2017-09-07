using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flatten_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, string>>();
            var flattenedDicts = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var tokens = input.Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "flatten")
                {
                    var dictKeyToFlatten = tokens[1];
                    var flattenedValue = "";

                    if (!flattenedDicts.ContainsKey(dictKeyToFlatten))
                    {
                        flattenedDicts[dictKeyToFlatten] = new List<string>();
                    }

                    foreach (var item in dict[dictKeyToFlatten])
                    {
                        flattenedValue = item.Key + item.Value;
                        flattenedDicts[dictKeyToFlatten].Add(flattenedValue);
                    }
                    dict[dictKeyToFlatten] = new Dictionary<string, string>();
                    continue;
                }

                var key = tokens[0];
                var innerKey = tokens[1];
                var innerValue = tokens[2];

                if (!dict.ContainsKey(key))
                {
                    dict[key] = new Dictionary<string, string>();
                }

                if (!dict[key].ContainsKey(innerKey))
                {
                    dict[key][innerKey] = "";
                }

                dict[key][innerKey] = innerValue;
            }

            // print

            foreach (var pair in dict.OrderByDescending(pair => pair.Key.Length))
            {
                var counter = 1;

                Console.WriteLine(pair.Key);
                var theKey = pair.Key;
                var innerDict = pair.Value;
                foreach (var item in innerDict.OrderBy(innerPair => innerPair.Key.Length))
                {
                    Console.WriteLine($"{counter}. {item.Key} - {item.Value}");
                    counter++;
                }

                if (flattenedDicts.ContainsKey(theKey))
                {
                    foreach (var flattenedValue in flattenedDicts[theKey])
                    {
                        Console.WriteLine($"{counter}. {flattenedValue}");
                        counter++;
                    }
                }
            }
        }
    }
}
