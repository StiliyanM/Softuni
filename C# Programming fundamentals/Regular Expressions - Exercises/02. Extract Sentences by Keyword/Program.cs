using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sentences = Console.ReadLine().Split(".?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var regex = "\\b" + word + "\\b";

            foreach (var s in sentences)
            {
                var isMatch = Regex.IsMatch(s, regex);
                
                if(isMatch)
                {
                    if(!s.StartsWith(" "))
                    Console.WriteLine(s);
                    else
                    {
                        Console.WriteLine(s.Remove(0,1));
                    }
                }
            }


        }
    }
}
