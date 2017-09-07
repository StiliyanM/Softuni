using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(\b([a-zA-Z]{1}[\w]{2,24})\b)";
            var input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);

            var userNames = new List<string>();
            foreach (Match m in matches)
            {
                userNames.Add(m.Value);
            }

            var maxLength = 0;
            string first = "";
            string second = "";

            for (int i = 0; i < userNames.Count - 1; i++)
            {
                var length = userNames[i].Length + userNames[i + 1].Length;
                if(length > maxLength)
                {
                    maxLength = length;
                    first = userNames[i];
                    second = userNames[i + 1];
                }
            }

            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
