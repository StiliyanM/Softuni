using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"<\/?a>?";

            var input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            while (input != "end")
            {
                Regex.Replace((input,@"<a","[URL"));
                input = Console.ReadLine();
            }
        }
    }
}
