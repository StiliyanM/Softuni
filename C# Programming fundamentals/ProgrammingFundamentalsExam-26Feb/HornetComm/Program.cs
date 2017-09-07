using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            var storedMessages = new List<string>();
            var storedBroadcasts = new List<string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Hornet is Green")
                {
                    break;
                }
                var messagePattern = @"^(\d+) <-> ([A-z\d]*)$";
                var broadcastPattern = @"^([^\d]+) <-> ([A-z\d]*)$";

                var messageMatch = Regex.Match(input, messagePattern);
                var broadcastMatch = Regex.Match(input, broadcastPattern);

                if (!messageMatch.Success && !broadcastMatch.Success)
                {
                    continue;
                }

                if (messageMatch.Success)
                {
                    var recipientCode = new string(messageMatch.Groups[1].Value.Reverse().ToArray());
                    var message = messageMatch.Groups[2].Value;

                    var storedMessage = $"{recipientCode} -> {message}";
                    storedMessages.Add(storedMessage);
                }
                if(broadcastMatch.Success)
                {
                    var message = broadcastMatch.Groups[1].Value;
                    var frequency =  new string(broadcastMatch.Groups[2].Value.
                        Select(x => x == char.ToLower(x) ? char.ToUpper(x) : char.ToLower(x)).
                        ToArray());

                    var broadcast = $"{frequency} -> {message}";
                    storedBroadcasts.Add(broadcast);
                }
            }
            Console.WriteLine("Broadcasts:");
            if(storedBroadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            foreach (var broadcast in storedBroadcasts)
            {
                Console.WriteLine(broadcast);
            }
            Console.WriteLine("Messages:");
            if(storedMessages.Count == 0)
            {
                Console.WriteLine("None");
            }
            foreach (var message in storedMessages)
            {
                Console.WriteLine(message);
            }
        }
    }
}