using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P04TreasureMap
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\![^!#]*?\b(?<street>[A-Za-z]{4})\b[^!#]*[^\d](?<number>\d{3})-(?<password>\d{6}|\d{4})(?:[^\d!#][^!#]*)?\#|\#[^!#]*?\b(?<street>[A-Za-z]{4})\b[^!#]*[^\d](?<number>\d{3})-(?<password>\d{6}|\d{4})(?:[^\d!#][^!#]*)?\!";

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var matches = Regex.Matches(input, pattern);

                var neededIndex = matches.Count / 2;
                var match = matches[neededIndex];

                var address = match.Groups["street"].Value;
                var streetNumber = match.Groups["number"].Value;
                var password = match.Groups["password"].Value;

                Console.WriteLine($"Go to str. {address} {streetNumber}. Secret pass: {password}.");
            }
        }
    }
}

