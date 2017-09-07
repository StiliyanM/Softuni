using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(?<str>(?![0-9]+)(.)*?)(?<number>[0-9]{1,2})";

            var stringsNumbers = Console.ReadLine().ToUpper();

            var result = new StringBuilder();

            foreach (Match item in Regex.Matches(stringsNumbers,pattern))
            {
                var str = item.Groups["str"].Value;
                var repeatCount = int.Parse(item.Groups["number"].Value);
                for (int i = 0; i < repeatCount; i++)
                {
                    result.Append(str);
                }
            }
            Console.WriteLine($"Unique symbols used: {result.ToString().Distinct().Count()}");
            Console.WriteLine(result);
        }
    }
}
