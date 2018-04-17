using System;
using System.Collections.Generic;
using System.Linq;

namespace P12InfernoIII
{
    class Program
    {
        static Dictionary<string, int> filtersIndexes = new Dictionary<string, int>();
        static List<Func<int, bool>> filters = new List<Func<int, bool>>();
        static List<int> numbers = new List<int>();
        static void Main(string[] args)
        {
            numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;

            var index = 0;
            while ((input = Console.ReadLine()) != "Forge")
            {
                var tokens = input.Split(';');

                var command = tokens[0];
                var filterType = tokens[1];
                var value = tokens[2];

                var filterInfo = filterType + value;
                if (command == "Exclude")
                {
                    if (!filtersIndexes.ContainsKey(filterInfo))
                    {
                        filtersIndexes[filterInfo] = 0;
                    }

                    filtersIndexes[filterInfo] = index;
                    index++;

                    var filter = GetFilter(filterType, value);
                    filters.Add(filter);
                }
                else if (command == "Reverse")
                {
                    var removeIndex = filtersIndexes[filterInfo];
                    index--;
                    filters.RemoveAt(removeIndex);
                }
            }

            for (int i = 0; i < filters.Count; i++)
            {
                numbers = numbers.Where(filters[i]).ToList();
            }

            Console.WriteLine(string.Join(" ",numbers));
        }

        private static Func<int, bool> GetFilter(string filterType, string value)
        {
            var numberValue = int.Parse(value);

            if (filterType == "Sum Left")
            {
                return number => (numbers.IndexOf(number) - 1 < 0 ? 0 : 
                   numbers[numbers.IndexOf(number) - 1]) + number != numberValue;
            }
            else if (filterType == "Sum Right")
            {
                return number => (numbers.IndexOf(number) + 1 >= numbers.Count ? 0 : 
                numbers[numbers.IndexOf(number) + 1])
                + number != numberValue;
            }

            return number => (numbers.IndexOf(number) - 1 < 0 ? 0 :
                   numbers[numbers.IndexOf(number) - 1]) +
                   (numbers.IndexOf(number) + 1 >= numbers.Count ? 0 :
                   numbers[numbers.IndexOf(number) + 1]) + number != numberValue;
        }
    }
}
