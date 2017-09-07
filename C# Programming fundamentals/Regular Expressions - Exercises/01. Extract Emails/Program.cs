using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(?<=\s)[a-z0-9]+([-\.]\w*)*@[a-z]+([-\.]\w*)*(\.[a-z]+)";

            var regex = new Regex(pattern);
            
            var text = Console.ReadLine();

            var emails = Regex.Matches(text, pattern);

            foreach (Match email in emails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
