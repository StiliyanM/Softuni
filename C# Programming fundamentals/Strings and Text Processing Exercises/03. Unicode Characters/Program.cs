using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] str = Console.ReadLine().ToArray();

            for (int i = 0; i < str.Length; i++)
            {
                int decvalue = str[i];
                string hexvalue = decvalue.ToString("X").ToLower();

                Console.Write($@"\u00{hexvalue}");
            }
            Console.WriteLine();
        }
    }
}
