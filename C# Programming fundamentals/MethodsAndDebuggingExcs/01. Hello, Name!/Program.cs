using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;
            string name = PrintMyName(text);

            Console.WriteLine($"Hello, {name}!");
        }

        static string PrintMyName(string name)
        {
            name = Console.ReadLine();
            return name;
        }
    }
}
