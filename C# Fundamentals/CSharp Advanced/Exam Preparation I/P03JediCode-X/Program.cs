using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P03JediCode_X
{
    class Program
    {
        static void Main()
        {
            var linesCount = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();

            for (int i = 0; i < linesCount; i++)
            {
                sb.Append(Console.ReadLine());
            }

            var text = sb.ToString();

            var jediCode = Console.ReadLine();
            var jediMessageCode = Console.ReadLine();

            var jediMatches = Regex.Matches(text, 
                $"(?<={jediCode})\\w{{{jediCode.Length}}}(?=[^A-Za-z])");
            var messagesMatches = Regex.Matches(text,
                $"(?<={jediMessageCode})[A-Za-z0-9]{{{jediMessageCode.Length}}}(?=[^A-Za-z0-9])");

            var indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Take(jediMatches.Count)
                .ToList();

            var resultBuilder = new StringBuilder();

            for (int i = 0; i < indexes.Count; i++)
            {
                var index = indexes[i] - 1;

                if(index < messagesMatches.Count)
                {
                    resultBuilder.AppendLine($"{jediMatches[i].Value} - {messagesMatches[index].Value}");
                }
                else
                {
                    if(i + 1 < messagesMatches.Count)
                    {
                        resultBuilder.AppendLine($"{jediMatches[i].Value} - {messagesMatches[i + 1].Value}");
                    }
                }
            }

            Console.WriteLine(resultBuilder.ToString().TrimEnd());
        }
    }
}
