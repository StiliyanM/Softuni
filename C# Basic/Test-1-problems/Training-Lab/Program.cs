using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            int rows = Convert.ToInt32(h * 100 / 120);
            int desks = Convert.ToInt32((w * 100 - 100) / 70);

            Console.WriteLine(rows * desks -3);
        }
    }
}
