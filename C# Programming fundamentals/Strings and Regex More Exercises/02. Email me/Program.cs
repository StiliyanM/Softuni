using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Email_me
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split('@');

            int before = 0;

                foreach (var item in tokens[0])
            {
                before += item;
            }

            int after = 0;
                foreach (var item in tokens[1])
            {
                after += item;
            }

            int sum = before - after;

            if (sum >= 0)
                Console.WriteLine("Call her!");
            else
                Console.WriteLine("She is not the one.");
        }
    }
}
