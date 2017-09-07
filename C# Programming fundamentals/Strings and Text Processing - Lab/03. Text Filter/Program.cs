using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            foreach (var bw in bannedWords)
            {
                text = text.Replace(bw, new string('*', bw.Length));
            }

            Console.WriteLine(text);
        }
    }
}
