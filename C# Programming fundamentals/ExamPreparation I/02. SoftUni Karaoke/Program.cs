using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().
                Split(",".ToCharArray()).
                Select(x => x.Trim())
                .ToArray();
            var songs = Console.ReadLine().Split(",".ToCharArray()).
                Select(x => x.Trim())
                .ToArray();

            var namesAwards = new Dictionary<string, HashSet<string>>();
            while (true)
            {
                var tokens = Console.ReadLine().
                    Split(",".ToCharArray()).ToArray();

                if(tokens[0] == "dawn")
                {
                    break;
                }
                var name = tokens[0];
                var song = tokens[1].Trim();
                var award = tokens[2].Trim();

                if(participants.Contains(name) && songs.Contains(song))
                {
                    if(!namesAwards.ContainsKey(name))
                    {
                        namesAwards[name] = new HashSet<string>();
                    }
 
                    namesAwards[name].Add(award);
                }
            }

            if(namesAwards.Values.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var n in namesAwards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                var singerName = n.Key;
                var awards = n.Value;
                var awardsCnt = n.Value.Count;

                Console.WriteLine($"{singerName}: {awardsCnt} awards");
                foreach (var a in awards.OrderBy(x => x))
                {
                    Console.WriteLine($"--{a}");
                }
            }
        }
    }
}
