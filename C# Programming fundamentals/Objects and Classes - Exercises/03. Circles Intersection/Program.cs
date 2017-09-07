using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Program
    {
        class Circle
        {
            public Point Center { get; set; }
            public int Radius { get; set; }
        }
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        static void Main(string[] args)
        {
            Circle c1 = ReadCircle();
            Circle c2 = ReadCircle();

            Console.WriteLine(Intersect(c1,c2) ? "Yes" : "No");
        }

        private static bool Intersect(Circle c1, Circle c2)
        {
            var distance = GetDistanceBetweenCircleCenters(c1.Center, c2.Center);

            if (distance <= c1.Radius + c2.Radius)
                return true;
            else
                return false;
        }

        private static double GetDistanceBetweenCircleCenters(Point p, Point q)
        {
            double a = p.X - q.X;
            double b = p.Y - q.Y;
            double distance = Math.Sqrt(a * a + b * b);
            return distance;
        }

        private static Circle ReadCircle()
        {
            var inputLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Circle circle = new Circle();

            circle.Radius = inputLine[2];

            Point point = new Point();
            point.X = inputLine[0];
            point.Y = inputLine[1];

            circle.Center = point;

            return circle;
        }
    }
}
