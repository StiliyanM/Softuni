using System;
using System.Collections.Generic;
using System.Text;

namespace P02PointInRectangle
{
    class Rectangle
    {
        public Point TopLeft { get; set; }

        public Point BottomRight { get; set; }

        public Rectangle()
        {

        }
        public Rectangle(int[] coordinates)
        {
            TopLeft = new Point(coordinates[0], coordinates[1]);
            BottomRight = new Point(coordinates[2], coordinates[3]);
        }

        public bool Contains(Point point)
        {
            bool containsX = point.X >= TopLeft.X && point.X <= BottomRight.X;
            bool containsY = point.Y >= TopLeft.Y && point.Y <= BottomRight.Y;

            return containsX && containsY;
        }
    }
}
