using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyString = Console.ReadLine();
            var textString = Console.ReadLine();

            var keysPattern = @"^(?<start>[a-zA-Z]+).*(?<=([|<\\]))(?<end>[a-zA-Z]+)$";

            Regex regex = new Regex(keysPattern);
            var match = regex.Match(keyString);

            var start = match.Groups["start"].Value;
            var end = match.Groups["end"].Value;
            var textPattern = start + @"(?<text>.*?)" + end;

            var matches = Regex.Matches(textString, textPattern);

            if(matches.Count > 0)
            foreach (Match m in matches)
            {
                Console.Write(m.Groups["text"].Value);
            }
            else
            {
                Console.Write("Empty result");
            }
            Console.WriteLine();
        }
    }
}
