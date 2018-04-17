using System;

namespace P09RectangleIntersection
{
    class Rectangle
    {
        public string Id { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double Horizontal { get; set; }
        public double Vertical { get; set; }

        public Rectangle(string id, double width, double height, double horizontal, double vertical)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.Horizontal = horizontal;
            this.Vertical = vertical;
        }

        public bool IntersectsWith(Rectangle r2)
        {
            var topLeftX = 
                Math.Abs(this.Horizontal) > Math.Abs(r2.Horizontal) + r2.Width;
            var bottomRightX = 
                Math.Abs(this.Horizontal) + Width < Math.Abs(r2.Horizontal);
            var topleftY = 
                Math.Abs(this.Vertical) < Math.Abs(r2.Vertical) - r2.Height;
            var bottomRightY = 
               Math.Abs(this.Vertical) - Height > Math.Abs(r2.Vertical);

            if (topLeftX || bottomRightX || topleftY || bottomRightY)
            {
               return false;
            }

            return true;
        }
    }
}
