using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_Messages
{
    class CubicMessages
    {
        static void Main()
        {
            List<string> results = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Over!")
                {
                    break;
                }

                int textLenght = int.Parse(Console.ReadLine());
                Regex validationRegex = new Regex($@"^\d+(?<text>[a-zA-Z]{{{textLenght}}})([^a-zA-Z]+)*$");

                Match cubicCode = validationRegex.Match(line);
                if (!cubicCode.Success)
                {
                    continue;
                }

                string cubicMessage = cubicCode.ToString();

                Regex indexesRegex = new Regex(@"\d");
                List<int> indexes = indexesRegex.Matches(cubicMessage)
                    .Cast<Match>()
                    .Select(a => int.Parse(a.Value))
                    .ToList();

                string text = cubicCode.Groups["text"].Value;

                var sbResult = new StringBuilder();

                for (int i = 0; i < indexes.Count; i++)
                {
                    try
                    {
                        sbResult.Append(text[indexes[i]]);
                    }
                    catch (Exception)
                    {
                        sbResult.Append(" ");
                    }
                }

                string result = $"{text} == {sbResult.ToString()}";
                results.Add(result);
            }

            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}