using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var input = Console.ReadLine();

            var numbers = Regex.Matches(input, regex);

            foreach (Match n in numbers)
            {
                Console.Write(n.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
