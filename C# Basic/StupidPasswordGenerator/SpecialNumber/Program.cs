using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            double workPlace = 70 * 120;
            double area = (w - 1) * h;

            double places = (int)area * workPlace - 3;

            Console.WriteLine(places);

        }
    }
}
