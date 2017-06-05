using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var inRange = (n >= 100 && n <= 200) || n == 0;

            if(!inRange)
                Console.WriteLine("invalid");
        }
    }
}
