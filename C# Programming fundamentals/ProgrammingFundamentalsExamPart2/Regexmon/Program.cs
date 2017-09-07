using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var matches = Regex.Matches(input, @"([^A-Za-z-]+).*?([A-Za-z]+-[A-Za-z]+).*?");

            //var didiRegex = new Regex(@"([^A-Za-z-]+)");
            //var bojoRegex = new Regex(@"([A-Za-z]+-[A-Za-z]+)");
            //int index = 0;
            //var sb = new StringBuilder();

            //while (index < input.Length)
            //{
            //    var didiMatch = didiRegex.Match(input.Substring(index));

            //    if (didiMatch.Success)
            //    {
            //        Console.WriteLine(didiMatch);
            //        index += didiMatch.Index + didiMatch.Length;
            //    }
            //    var bojoMatch = bojoRegex.Match(input.Substring(index));
            //    if (bojoMatch.Success)
            //    {
            //        Console.WriteLine(bojoMatch);
            //        index += bojoMatch.Index + bojoMatch.Length;
            //    }

            //}

            var index = 0;
            foreach (Match match in matches)
            {
                if (!match.Success)
                {
                    continue;
                }
                if (match.Value == "")
                {
                    continue;
                }
                var didiString = match.Groups[1].Value;
                var bojoString = match.Groups[2].Value;

                if (didiString != "")
                {
                    Console.WriteLine(didiString);
                    index = match.Groups[1].Index + match.Groups[1].Length;
                }
                if (bojoString != "")
                {
                    Console.WriteLine(bojoString);
                    index = match.Groups[2].Index + match.Groups[2].Length;
                }
            }

            if(index < input.Length)
            {
                var match = Regex.Match(input.Substring(index), @"[^A-Za-z-]+");
                if(match.Success)
                Console.WriteLine(match.Value);

            }
        }
    }
}
