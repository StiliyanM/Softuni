using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const int Search = 112;
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int endIndex = jump;

                    if (endIndex > text.Length - 1 - i)
                    {
                        endIndex = text.Length - 1 - i;
                    }

                    string matchedString = text.Substring(i, endIndex + 1);
                    Console.WriteLine(matchedString);
                    i += endIndex;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
