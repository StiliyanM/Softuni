using System;
using System.Collections.Generic;
using System.Linq;

namespace P11PartyReservationFilterModule
{
    class Program
    {
        static List<Func<string, bool>> filterList = new List<Func<string, bool>>();

        static Dictionary<string, int> filtersAdded = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split().ToList();

            string input;

            var index = 0;
            while ((input = Console.ReadLine()) != "Print")
            {
                var tokens = input.Split(';');

                var command = tokens[0];
                var filterName = tokens[1];
                var filter = tokens[2];

                if(command == "Add filter")
                {
                    filterList.Add(GetFilter(filterName, filter));
                    if(!filtersAdded.ContainsKey(filterName + filter))
                    {
                        filtersAdded[filterName + filter] = 0;
                    }
                    filtersAdded[filterName + filter] = index;
                    index++;
                }
                else
                {
                    var deleteIndex = filtersAdded[filterName + filter];
                    filterList.RemoveAt(deleteIndex);
                    index--;
                }
            }

            foreach (var f in filterList)
            {
                people = people.Where(e => !f(e)).ToList();
            }

            Console.WriteLine(string.Join(" ",people));

        }

        private static Func<string, bool> GetFilter(string filterName, string filter)
        {
            if (filterName == "Starts with")
            {
                return str => str.StartsWith(filter);
            }
            else if (filterName == "Ends with")
            {
                return str => str.EndsWith(filter);
            }
            else if (filterName == "Contains")
            {
                return str => str.Contains(filter);
            }

            return str => str.Length == int.Parse(filter);
        }
    }
}
