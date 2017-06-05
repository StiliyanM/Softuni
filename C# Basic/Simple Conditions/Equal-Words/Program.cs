using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToLower();
            var wordToCompare = Console.ReadLine().ToLower();

            if(word == wordToCompare)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
