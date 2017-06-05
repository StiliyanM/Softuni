using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                if(n % 2 != 0)
                {
                    string underline = new string('-', (n - 2 * i + 1) / 2 - 1);
                    string stars = new string('*', 2 * i + 1);
                    Console.WriteLine(underline + stars + underline);
                }
                if (n % 2 == 0)
                {
                    string underline = new string('-', (n - 2 * i + 2) / 2 - 2);
                    string stars = new string('*', 2 * i + 2);

                    Console.WriteLine(underline + stars + underline);
                }
            }
            for (int i = 0; i < n - (n + 1) / 2; i++)
            {
                string pipe ="|";
                Console.WriteLine(pipe + new string('*', n - 2) + pipe);
            }
        }
    }
}
