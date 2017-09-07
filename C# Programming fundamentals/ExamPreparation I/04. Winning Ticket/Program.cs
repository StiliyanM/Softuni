using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Regex.Split(Console.ReadLine(), @"[,\s]+");

            var pattern = @"(?<dollars>\${6,10})|(?<address>@{6,10})|(?<hashtag>#{6,10})|(?<up>\^{6,10})";
            foreach (var ticket in tickets)
            {
                if(ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var firstPart = ticket.Substring(0, 10);
                var secondPart = ticket.Substring(10, 10);

                Regex regex = new Regex(pattern);

                var firstPartMatch = regex.Match(firstPart);
                var secondPartMatch = regex.Match(secondPart);

                if (!firstPartMatch.Success || !secondPartMatch.Success)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                    continue;
                }
                if(firstPartMatch.Value[0] != secondPartMatch.Value[0])
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                    continue;
                }

                if (firstPartMatch.Length == 10 && secondPartMatch.Length == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" -" +
                            $" {firstPartMatch.Length}{firstPartMatch.Value[0]} Jackpot!");
                    }
                    else
                    {
                    var minLength = Math.Min(firstPartMatch.Length,secondPartMatch.Length);
                    Console.WriteLine($"ticket \"{ticket}\" " +
                        $"- {minLength}{firstPartMatch.Value[0]}");
                    }
            }
        }
    }
}
