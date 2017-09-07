using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {

            var EventsParticipants = new Dictionary<string,HashSet<string>>();
            var idsEvents = new Dictionary<string, string>();

            var eventPattern = @"(?<id>\d+)\s+#(?<eventName>[\w\d]+)(\s(?<participants>.*))*";
            while (true)
            {
                var line = Console.ReadLine();

                if (line == "Time for Code")
                {
                    break;
                }

                var eventMatch = Regex.Match(line, eventPattern);
                if (!eventMatch.Success)
                {
                    continue;
                }

                string id = eventMatch.Groups["id"].Value;
                var eventName = eventMatch.Groups["eventName"].Value;
                if (!idsEvents.ContainsKey(id))
                {
                    EventsParticipants[eventName] = new HashSet<string>();
                    idsEvents[id] = eventName;
                }
                if (idsEvents.ContainsValue(eventName))
                {
                    var participants = Regex.Split(eventMatch.Groups["participants"].Value, @"\s");

                    foreach (var p in participants.Where(p => p != ""))
                    {
                        EventsParticipants[eventName].Add(p);
                    }
                }
            }

            foreach (var ep in EventsParticipants.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{ep.Key} - {ep.Value.Count}");

                foreach (var item in ep.Value.OrderBy(x => x))
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}

