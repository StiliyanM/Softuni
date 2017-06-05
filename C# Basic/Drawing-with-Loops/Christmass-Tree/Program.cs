using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmass_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n + 1; i++)
            {
                string spaces = new string(' ', n - i);
                string stars = new string('*', i);
                string pipe = " | ";

                Console.WriteLine(spaces + stars + pipe + stars);
            }
        }
    }
}
