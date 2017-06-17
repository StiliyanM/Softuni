using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {

            var hands = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(':').ToArray();

                if (input[0] == "JOKER")
                {
                    foreach (var item in hands)
                    {

                        var totalCards = item.Value.Distinct();
                        int sum = 0;

                        foreach (var card in totalCards)
                        {
                            char type = card.Last();
                            string power = string.Empty;
                            if (card.Length > 3)
                                 power = "10";
                            else
                            {
                                power = card[1].ToString();
                            }

                            sum += GetSum(power, type);
                        }
                        Console.WriteLine(item.Key + ": " + sum);
                    }
                    break;
                }

                char[] separator = { ',' };
                string name = input[0];
                var cards = input[1].Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

                if(hands.ContainsKey(name))
                {
                    foreach (var item in cards)
                    {
                        hands[name].Add(item);
                    }
                    
                }
                else
                {
                    hands[name] = new List<string>(cards);
                }

            }
        }

        private static int GetSum(string power, char type)
        {
            int powerNum = 0;
            switch (power)
            {
                case "J": powerNum = 11; break;
                case "Q": powerNum = 12; break;
                case "K": powerNum = 13; break;
                case "A": powerNum = 14; break;
                default:
                    powerNum = int.Parse(power);
                    break;
            }
            int typeNum = 0;

            switch (type)
            {
                case 'S': typeNum = 4; break;
                case 'H': typeNum = 3; break;
                case 'D': typeNum = 2; break;
                case 'C': typeNum = 1; break;
                default:
                    break;
            }
            return typeNum * powerNum;
        }
    }
}
