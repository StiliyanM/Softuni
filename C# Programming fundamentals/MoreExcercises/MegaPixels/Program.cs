using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaPixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());

            double pixels = w * h;
            double megaPixels = Math.Round(pixels / 1000000, 1);

            Console.WriteLine($"{w}x{h} => {megaPixels}MP");
        }
    }
}
