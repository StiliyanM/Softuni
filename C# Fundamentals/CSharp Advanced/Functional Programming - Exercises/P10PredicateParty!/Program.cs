using System;
using System.Collections.Generic;
using System.Linq;

namespace P10PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split().ToList();

            string input;

            Func<string, string, bool> startsWith = (str, criteria) => str.StartsWith(criteria);
            Func<string, string, bool> endsWith = (str, criteria) => str.EndsWith(criteria);
            Func<string, int, bool> withGivenLength = (str, criteria) => str.Length == criteria;

            while ((input = Console.ReadLine()) != "Party!")
            {
                var tokens = input.Split();
                var command = tokens[0];
                var predicateName = tokens[1];

                if (command == "Remove")
                {
                    if (predicateName == "StartsWith")
                    {
                        var startingString = tokens[2];
                        people = people.Where(p => !startsWith(p, startingString)).ToList();
                    }
                    else if (predicateName == "EndsWith")
                    {
                        var endingString = tokens[2];
                        people = people.Where(p => !endsWith(p, endingString)).ToList();
                    }
                    else if (predicateName == "Length")
                    {
                        var length = int.Parse(tokens[2]);
                        people = people.Where(p => !withGivenLength(p, length)).ToList();
                    }
                }
                else if (command == "Double")
                {
                    if (predicateName == "StartsWith")
                    {
                        var startingString = tokens[2];
                        people.AddRange(people.Where(p => startsWith(p, startingString)).ToList());
                    }
                    else if (predicateName == "EndsWith")
                    {
                        var endingString = tokens[2];
                        people.AddRange(people.Where(p => endsWith(p, endingString)).ToList());
                    }
                    else if (predicateName == "Length")
                    {
                        var length = int.Parse(tokens[2]);
                        people.AddRange(people.Where(p => withGivenLength(p, length)).ToList());
                    }
                }
            }

            if (people.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                people = SortInRequestedOrder(people);
                Console.Write(string.Join(", ", people));
                Console.WriteLine(" are going to the party!");
            }
        }

        static List<string> SortInRequestedOrder(List<string> list)
        {
            var namesCounts = new Dictionary<string, int>();

            foreach (var name in list)
            {
                if (!namesCounts.ContainsKey(name))
                {
                    namesCounts[name] = 0;
                }
                namesCounts[name] += 1;
            }

            list = list.Distinct().ToList();

            var resultList = new List<string>();

            foreach (var name in list)
            {
                for (int i = 0; i < namesCounts[name]; i++)
                {
                    resultList.Add(name);
                }
            }

            return resultList;
        }
    }
}
