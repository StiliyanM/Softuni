using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var minePattern = @"<.{2}>";
            var mines = Regex.Matches(text, minePattern);

            foreach (Match mine in mines)
            {
                var mineString = mine.ToString();
                int power = Math.Abs(mineString[1] - mineString[2]);
                int minDistance = Math.Min(mine.Index, text.Length - mine.Index - 3);
                int maxPower = Math.Min(power,minDistance);
                var pattern = $".{{{maxPower}}}<.{{2}}>.{{{maxPower}}}";
                text = Regex.Replace(text, pattern, new string('_',maxPower * 2 + 4));
            }

            Console.WriteLine(text);
        }
    }
}
