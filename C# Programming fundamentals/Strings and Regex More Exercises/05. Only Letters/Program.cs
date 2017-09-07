using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var numbersPattern = @"[0-9]+([a-zA-Z])";

            Regex regex = new Regex(numbersPattern);
            var matches = Regex.Matches(inputLine, numbersPattern);
            foreach (Match m in matches)
            {
               inputLine = inputLine.Replace(m.Value, m.Groups[1].Value + m.Groups[1].Value);
            }
            
            Console.WriteLine(inputLine);
        }
    }
}
