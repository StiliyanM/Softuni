using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var getTextPattern = @"(?<=(<p>))(?<text>.*?)(?=(<\/p>))";
            var replacePattern = @"(?![a-z0-9])\(.)*?";
            var matches = Regex.Matches(inputLine, getTextPattern);

            var text = "";
            foreach (Match m in matches)
            {
                text += m.Groups["text"].Value;
            }

            Regex regexReplace = new Regex(replacePattern);

            var replaceMatches = regexReplace.Matches(text);
            foreach (var item in replaceMatches)
            {

            }
            Console.WriteLine();
            
        }
    }
}
