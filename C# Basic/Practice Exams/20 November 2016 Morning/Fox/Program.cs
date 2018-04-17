using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            // first part 

            for (int i = 0; i < n; i++)
            {
                string stars = new string('*', 1 + i);
                string dashes = new string('-', 2 * n - 1 - 2 * i);

                Console.WriteLine(stars + '\\' + dashes + '/' + stars);
            }

            // middle part

            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine('|' + new string('*', n / 2 + i) + '\\' + new string('*', n - 2 * i)
                    + '/' + new string('*', n / 2 + i) + '|') ;
            }

            // last part

            for (int i = 0; i < n; i++)
            {
                string stars = new string('*',2 * n - 1 - 2 * i);
                string dashes = new string('-',1 + i);

                Console.WriteLine(dashes + '\\' + stars + '/' + dashes);
            }
            
        }
    }
}
