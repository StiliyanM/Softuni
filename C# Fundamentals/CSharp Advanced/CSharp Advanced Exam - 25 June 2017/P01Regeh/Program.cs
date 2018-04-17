using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P01Regeh
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\[[^\s\[\]]+<(\d+)REGEH(\d+)>[^\s\[\]]+]";

            var input = Console.ReadLine();
            var matches = Regex.Matches(input, pattern);

            var indexes = new List<int>();
            foreach (Match m in matches)
            {
                indexes.Add(int.Parse(m.Groups[1].Value));
                indexes.Add(int.Parse(m.Groups[2].Value));
            }

            var sb = new StringBuilder();
            for (int i = 0; i < indexes.Count; i++)
            {
                int currentIndex = indexes[i] + indexes.GetRange(0, i).Sum();
                sb.Append(input[currentIndex % input.Length]);
            }

            Console.WriteLine(sb);

        }
    }
}
