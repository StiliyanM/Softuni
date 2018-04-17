using System;
using System.Collections.Generic;
using System.Linq;

namespace P09RectangleIntersection
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();

            int rectangleCount = int.Parse(input[0]);
            int intersectionChecks = int.Parse(input[1]);

            var rectangles = new List<Rectangle>(rectangleCount);

            for (int i = 0; i < rectangleCount; i++)
            {
                var rectangleInput = Console.ReadLine().Split();

                var id = rectangleInput[0];
                var width = double.Parse(rectangleInput[1]);
                var height = double.Parse(rectangleInput[2]);
                var horizontal = double.Parse(rectangleInput[3]);
                var vertical = double.Parse(rectangleInput[4]);

                var rectangle = new Rectangle(id,width,height,horizontal,vertical);

                rectangles.Add(rectangle);
            }

            for (int i = 0; i < intersectionChecks; i++)
            {
                var rectangleIds = Console.ReadLine().Split();

                var firstRectangleID = rectangleIds[0];
                var secondRectangleId = rectangleIds[1];

                var firstRectangle = rectangles.First(r => r.Id == firstRectangleID);
                var secondRectangle = rectangles.First(r => r.Id == secondRectangleId);

                if (firstRectangle.IntersectsWith(secondRectangle))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
