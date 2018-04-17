using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace P03NumberWars
{
    class NumberWars
    {
        static void Main()
        {
            var player1Cards = new Queue<string>(Console.ReadLine().Split());
            var player2Cards = new Queue<string>(Console.ReadLine().Split());

            int turns = 0;

            string pattern = @"(?<number>\d+)(?<letter>[A-Za-z])";
            var regex = new Regex(pattern);

            while ((player1Cards.Count != 0 && player2Cards.Count != 0) && turns <= 10000)
            {
                turns++;

                string firstPlayer1Card = player1Cards.Dequeue();
                string firstPlayer2Card = player2Cards.Dequeue();

                int firstPlayer1CardDigit = int.Parse(regex.Match(firstPlayer1Card).Groups["number"].Value);
                int firstPlayer2CardDigit = int.Parse(regex.Match(firstPlayer2Card).Groups["number"].Value);

                if (firstPlayer1CardDigit == firstPlayer2CardDigit)
                {
                    if (player1Cards.Count < 3)
                    {
                        Console.WriteLine($"Second player wins after {turns} turns");
                        return;
                    }
                    else if (player2Cards.Count < 3)
                    {
                        Console.WriteLine($"First player wins after {turns} turns");
                        return;
                    }
                    else
                    {
                        var cards = new List<string>(6);

                        cards.Add(firstPlayer1Card);
                        cards.Add(firstPlayer2Card);

                        int player1Sum = 0;
                        int player2Sum = 0;

                        while (player1Sum == player2Sum)
                        {
                            for (int counter = 1; counter <= 3; counter++)
                            {
                                try
                                {
                                    cards.Add(player1Cards.Peek());
                                    cards.Add(player2Cards.Peek());

                                    player1Sum += (int)char.Parse(regex.Match(player1Cards.Dequeue()).Groups["letter"].Value);
                                    player2Sum += (int)char.Parse(regex.Match(player2Cards.Dequeue()).Groups["letter"].Value);
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine($"Draw after {turns} turns");
                                    return;
                                }
                            }
                        }

                        cards = cards
                            .OrderByDescending(card => int.Parse(regex.Match(card).Groups["number"].Value))
                            .ThenByDescending(card => regex.Match(card).Groups["letter"].Value)
                            .ToList();

                        if (player1Sum > player2Sum)
                        {
                            for (int index = 0; index < cards.Count; index++)
                            {
                                player1Cards.Enqueue(cards[index]);
                            }
                        }
                        else
                        {
                            for (int index = 0; index < cards.Count; index++)
                            {
                                player2Cards.Enqueue(cards[index]);
                            }
                        }
                    }
                }
                else if (firstPlayer1CardDigit > firstPlayer2CardDigit)
                {
                    player1Cards.Enqueue(firstPlayer1Card);
                    player1Cards.Enqueue(firstPlayer2Card);
                }
                else
                {
                    player2Cards.Enqueue(firstPlayer2Card);
                    player2Cards.Enqueue(firstPlayer1Card);
                }
            }

            if (player1Cards.Count > player2Cards.Count)
            {
                Console.WriteLine($"First player wins after {turns} turns");
            }
            else
            {
                Console.WriteLine($"Second player wins after {turns} turns");
            }
        }
        }
    }
}