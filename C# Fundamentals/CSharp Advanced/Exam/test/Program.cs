using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P03CryptoBlockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(\[|{).*?(?<digits>\d{3,}).*?(\]|})";

            var linesCount = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();
            for (int i = 0; i < linesCount; i++)
            {
                sb.Append(Console.ReadLine());
            }

            var matches = Regex.Matches(sb.ToString(), pattern);

            var result = new StringBuilder();
            foreach (Match match in matches)
            {
                if (!MatchIsLegit(match))
                {
                    continue;
                }

                var numbers = GetNumbers(match);

                string str = GetString(numbers);

                result.Append(str);
            }

            Console.WriteLine(result);
        }

        private static string GetString(List<int> numbers)
        {
            var str = new StringBuilder();
            foreach (var n in numbers)
            {
                str.Append((char)n);
            }

            return str.ToString();
        }

        private static List<int> GetNumbers(Match match)
        {
            var numbers = new List<int>();

            var digits = match.Groups["digits"].Value;

            var cryptoBlockLength = match.Length;

            for (int i = 0; i < digits.Length; i += 3)
            {
                var stringNumber = digits.Substring(i, 3);

                if (stringNumber[0] == '0')
                {
                    stringNumber = stringNumber.Substring(1, 2);

                    if (stringNumber[0] == '0')
                    {
                        stringNumber = stringNumber.Substring(1, 1);
                    }
                }

                numbers.Add(int.Parse(stringNumber));
            }

            return numbers.Select(e => e -= cryptoBlockLength).ToList();
        }

        private static bool MatchIsLegit(Match match)
        {
            var block = match.Value;

            bool equalParenthesis = (block[0] == '{' && block.Last() == '}') ||
                                    (block[0] == '[' && block.Last() == ']');

            var numbers = match.Groups["digits"].Value;

            bool divisibleBy3 = numbers.Length % 3 == 0;

            return equalParenthesis && divisibleBy3;
        }
    }
}
