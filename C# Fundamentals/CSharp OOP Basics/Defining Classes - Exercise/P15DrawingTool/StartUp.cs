using System;

namespace P15DrawingTool
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var typeOfFigure = Console.ReadLine();

            var drawingTool = new DrawingTool();
            if (typeOfFigure.Equals("Square", StringComparison.InvariantCultureIgnoreCase))
            {
                var square = new Square();
                var side = int.Parse(Console.ReadLine());
                square.Side = side;                
                drawingTool = new DrawingTool(square);
            }
            else
            {
                var width = int.Parse(Console.ReadLine());
                var length = int.Parse(Console.ReadLine());

                var rectangle = new Rectangle
                {
                    Width = width,
                    Length = length
                };

                drawingTool = new DrawingTool(rectangle);
            }
        }
    }
}
