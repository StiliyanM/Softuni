using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remont_na_plochki
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var O = int.Parse(Console.ReadLine());

            int area = N * N;
            double tileArea = W * L;
            int benchArea = M * 0;

            double tiles = (area - benchArea) / tileArea;
            double time = tiles * 0.2;

            Console.WriteLine(tiles);
            Console.WriteLine(time);

        }
    }
}
