using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Program
    {

        class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public int Right
            { get
                {
                    return Left + Width;
                }
            }

            public int Bottom
            {
                get
                {
                    return Top + Height;
                }
            }

            public bool IsInside(Rectangle other)
            {
                var isInLeft = Left >= other.Left;
                var isInRight = Right <= other.Right;

                var isInsideHorizontal = isInLeft && isInRight;

                var isInTop = Top >= other.Top;
                var isInBottom = Bottom <= other.Bottom;

                var isInsideVertical = isInTop && isInBottom;

                return isInsideHorizontal && isInsideVertical;
            }
        }
        static void Main(string[] args)
        {
            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();

            Console.WriteLine(r1.IsInside(r2) ? "Inside" : "Not inside");
        }

        private static Rectangle ReadRectangle()
        {
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Rectangle rectangle = new Rectangle();
            {
                rectangle.Left = size[0];
                rectangle.Top = size[1];
                rectangle.Width = size[2];
                rectangle.Height = size[3];
            }
            return rectangle;
        }
    }
}
