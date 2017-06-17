using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            double area = 0;
            if (type == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                area = side * height / 2;
            }
            else if (type == "square")
            {
                double side = double.Parse(Console.ReadLine());

                area = side * side;
            }
            else if(type == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                area = width * height;
            }
            else if(type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                area = Math.PI * radius * radius;
            }

            Console.WriteLine(Math.Round(area, 2));
        }
    }
}
