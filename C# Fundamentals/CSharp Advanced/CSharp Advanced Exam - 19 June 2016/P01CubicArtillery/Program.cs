using System;
using System.Collections.Generic;
using System.Linq;
namespace P01CubicArtillery
{
    class Program
    {
        static void Main(string[] args)
        {
            var bunkers = new List<Dictionary<char, Queue<int>>>();

            var maxCapacity = int.Parse(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "Bunker Revision")
            {
                var tokens = input.Split();

                var lastBunker = ' ';
                for (int i = 0; i < tokens.Length; i++)
                {
                    char character;
                    var isChar = char.TryParse(tokens[i], out character);

                    if(isChar && char.IsLetter(character))
                    {
                        lastBunker = character;

                        var bunker = new Dictionary<char, Queue<int>>();
                    }
                }
            }
        }
    }
}
