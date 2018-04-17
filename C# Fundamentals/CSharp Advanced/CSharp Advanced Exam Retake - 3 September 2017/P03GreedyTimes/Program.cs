using System;
using System.Linq;
using System.Collections.Generic;

namespace P03GreedyTimes
{
    class Program
    {
        const string gold = "Gold";
        const string gem = "Gem";
        const string cash = "Cash";

        static Dictionary<string, Dictionary<string, ulong>> bag;
        static void Main(string[] args)
        {
            bag = new Dictionary<string, Dictionary<string, ulong>>()
            {
                { "Gold",new Dictionary<string, ulong>()},
                {"Gem",new Dictionary<string, ulong>() },
                {"Cash",new Dictionary<string, ulong>() }
            };

            var bagCapacity = ulong.Parse(Console.ReadLine());

            var pairs = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            ulong overallAmount = 0;
            for (int i = 0; i < pairs.Length - 1; i += 2)
            {
                var type = pairs[i];
                var amount = ulong.Parse(pairs[i + 1]);

                if (!IsValid(type))
                {
                    continue;
                }
                if (!IsAllowed(type, amount))
                {
                    continue;
                }

                overallAmount += amount;
                if (overallAmount > bagCapacity)
                {
                    break;
                }

                if (string.Equals(gold, type, StringComparison.InvariantCultureIgnoreCase))
                {
                    if (!bag[gold].ContainsKey(gold))
                    {
                        bag[gold][gold] = 0;
                    }
                    bag[gold][gold] += amount;
                }
                else if (type.Length == 3)
                {
                    if (!bag[cash].ContainsKey(type))
                    {
                        bag[cash][type] = 0;
                    }

                    bag[cash][type] += amount;
                }
                else
                {
                    if (!bag[gem].ContainsKey(type))
                    {
                        bag[gem][type] = 0;
                    }

                    bag[gem][type] += amount;
                }

            }

            foreach (var kv in bag.OrderByDescending(e => e.Value.Sum(r => (decimal)r.Value)))
            {
                var overallType = kv.Key;

                var sum = kv.Value.Sum(e => (decimal)e.Value);

                if (kv.Value.Count != 0)
                {
                    Console.WriteLine($"<{overallType}> ${sum}");
                }
                else
                {
                    continue;
                }

                foreach (var pair in kv.Value
                                        .OrderByDescending(e => e.Key)
                                        .ThenBy(e => e.Value))
                {
                    Console.WriteLine($"##{pair.Key} - {pair.Value}");
                }
            }
        }

        private static bool IsAllowed(string type, ulong amount)
        {
            ulong goldAmount = 0;
            ulong gemAmount = 0;
            ulong cashAmount = 0;
            foreach (var kv in bag)
            {
                foreach (var pair in kv.Value)
                {
                    if (kv.Key == gold)
                    {
                        goldAmount += pair.Value;
                    }
                    else if (kv.Key == gem)
                    {
                        gemAmount += pair.Value;
                    }
                    else
                    {
                        cashAmount += pair.Value;
                    }
                }
            }
            if (string.Equals(gold, type, StringComparison.InvariantCultureIgnoreCase))
            {
                goldAmount += amount;
            }
            else if (type.Length == 3)
            {
                cashAmount += amount;
            }
            else if (type.Length >= 4)
            {
                if (type.Substring(type.Length - 3, 3).Equals(gem, StringComparison.InvariantCultureIgnoreCase))
                    gemAmount += amount;
            }

            if (goldAmount < gemAmount)
            {
                return false;
            }
            if (gemAmount < cashAmount)
            {
                return false;
            }

            return true;
        }

        private static bool IsValid(string type)
        {
            if (string.Equals(gold, type, StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            else if (type.Length == 3)
            {
                return true;
            }
            else if (type.Length >= 4)
            {
                if (type.Substring(type.Length - 3, 3).Equals(gem, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }

            return false;
        }
    }
}
