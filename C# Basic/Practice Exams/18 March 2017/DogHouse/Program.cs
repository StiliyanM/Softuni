using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            double sideWalls = a * a;
            double backWall = Math.Pow(a / 2, 2) + a / 2 * (b - a / 2) / 2;
            double frontWall = backWall - Math.Pow(a / 5, 2);
            double roof = a * a ;

            double green = (sideWalls + backWall + frontWall) / 3;
            double red = roof / 5;

            Console.WriteLine($"{green:f2}");
            Console.WriteLine($"{red:f2}");
        }
    }
}
