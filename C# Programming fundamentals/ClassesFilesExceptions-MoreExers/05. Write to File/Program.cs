using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Write_to_File
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] punctuationMarks = { '.', ',', '!', '?', ':' };
            var text = File.ReadAllText("sample_text.txt");

            var result = string.Empty;
            foreach (var c in text)
            {
                if (!(c == '.' || c == ',' || c == '!' || c == '?' || c == ':'))
                {
                    result += c;
                }
            }
            

            Console.WriteLine(result);
        }
    }
}
