using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideLength = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            double result = 0;
            switch (parameter)
            {
                case "face":
                    result = Math.Sqrt(2 * sideLength * sideLength);
                    break;
                case "space":
                    result = Math.Sqrt(3 * sideLength * sideLength);
                    break;
                case "volume":
                    result = Math.Pow(sideLength, 3);
                    break;
                case "area":
                    result = 6 * sideLength * sideLength;
                    break;
                default:
                    break;
            }

            Console.WriteLine(Math.Round(result,2));
        }
    }
}
