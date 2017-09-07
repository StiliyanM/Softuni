using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var venuesSingersMoney = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var tokens = Console.ReadLine().Split().ToArray();

                if (tokens[0] == "End")
                {
                    foreach (var v in venuesSingersMoney)
                    {
                        Console.WriteLine(v.Key);
                        var singersMoney = v.Value;

                        foreach (var s in singersMoney.OrderByDescending(x => x.Value))
                        {
                            var name = s.Key;
                            var moneyMade = s.Value;
                            Console.WriteLine($"#  {name} -> {moneyMade}");
                        }
                    }
                    break;
                }

                while (!tokens.Contains("@") && tokens.Length < 4)
                {
                    tokens = Console.ReadLine().Split().ToArray();

                    if (tokens[0] == "End")
                        break;
                }

                tokens = string.Join(" ", tokens).Split('@').ToArray();

                string singer = tokens[0].Remove(tokens[0].Length - 1);

                var venueDigits = tokens[1].Split().ToArray();

                string venue = string.Empty;
                if (venueDigits.Length == 4)
                {
                    venue = venueDigits[0] + " " + venueDigits[1];
                }
                else
                {
                    venue = venueDigits[0];
                }

                long ticketPrice = long.Parse(venueDigits[venueDigits.Length - 2]);
                long ticketCount = long.Parse(venueDigits[venueDigits.Length - 1]);

                long money = ticketCount * ticketPrice;

                if (!venuesSingersMoney.ContainsKey(venue))
                {
                    venuesSingersMoney[venue] = new Dictionary<string, long>();
                }

                if (!venuesSingersMoney[venue].ContainsKey(singer))
                {
                    venuesSingersMoney[venue][singer] = money;
                }
                else
                {
                    venuesSingersMoney[venue][singer] += money;
                }
            }
        }
    }
}
