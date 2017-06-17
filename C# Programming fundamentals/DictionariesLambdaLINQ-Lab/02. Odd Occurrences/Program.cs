using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split().ToList();

            var counts = new Dictionary<string, int>();

            foreach (var w in words)
            {
                if(counts.ContainsKey(w))
                {
                    counts[w]++;
                }
                else
                {
                    counts[w] = 1;
                }
            }
            var results = new List<string>();

            foreach (var item in counts.Keys)
            {
                if (counts[item] % 2 == 1)
                    results.Add(item);
            }

            Console.WriteLine(string.Join(", ", results));
        }
    }
}
