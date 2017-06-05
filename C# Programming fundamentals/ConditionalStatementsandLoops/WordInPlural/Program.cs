using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                word = word.Insert(word.Length, "ies");
            }
            else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s")
                || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                word = word.Insert(word.Length, "es");
            }
            else
            {
                word = word.Insert(word.Length, "s");
            }

            Console.WriteLine(word);
        }
    }
}
