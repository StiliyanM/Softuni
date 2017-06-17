using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            string result = GetClosestToCenter(x1, x2, y1, y2);
            Console.WriteLine(result);
        }

        private static string GetClosestToCenter(double x1, double x2, double y1, double y2)
        {

            double num1 = 0;
            double num2 = 0;

            double xDistance = (x1 * x1 + y1 * y1);
            double yDistance = (x2 * x2 + y2 * y2);

            if (xDistance >= yDistance)
            {
                num1 = x2;
                num2 = y2;
            }
            else 
            {
                num1 = x1;
                num2 = y1;
            }

            string result = $"({num1}, {num2})";
            return result;



       }
    }
}
