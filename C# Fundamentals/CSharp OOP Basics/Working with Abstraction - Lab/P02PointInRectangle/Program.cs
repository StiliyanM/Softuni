using System;
using System.Linq;

namespace P02PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var rectangle = new Rectangle(coordinates);

            var linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                var point = new Point(Console.ReadLine().Split().Select(int.Parse).ToArray());

                Console.WriteLine(rectangle.Contains(point));
            }
        }
    }
}
