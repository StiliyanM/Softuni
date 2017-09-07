using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.Punctuation_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] punctuationMarks = { '.', ',', '!', '?', ':' };
            var text = File.ReadAllText("sample_text.txt");

            var result = new List<char>();
            foreach (var c in text)
            {
                if(c == '.' || c == ',' || c == '!' || c == '?' || c == ':')
                {
                    result.Add(c);
                }
            }

            //text = text.FindAll(x => punctuationMarks.Any(y => y == x)).ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
