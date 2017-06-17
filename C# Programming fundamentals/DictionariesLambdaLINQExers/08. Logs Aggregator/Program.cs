using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var nameIpDuration = new SortedDictionary<string, SortedDictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                string name = input[1];
                string ip = input[0];
                int duration = int.Parse(input[2]);

                if(!nameIpDuration.ContainsKey(name))
                {
                    nameIpDuration[name] = new SortedDictionary<string, int>();
                }

                if(!nameIpDuration[name].ContainsKey(ip))
                {
                    nameIpDuration[name][ip] = 0;
                }

                    nameIpDuration[name][ip] += duration;
                

            }

            
            foreach (var name in nameIpDuration)
            {
                
                string theName = name.Key;
                var ipsDurations = name.Value;
                var totalDuration = ipsDurations.Values.Sum();
                var ips = ipsDurations.Select(a => a.Key).ToArray();

                Console.WriteLine("{0}: {1} [{2}]", theName, totalDuration, string.Join(", ", ips));
 
            }
        }
    }
}
