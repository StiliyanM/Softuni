namespace P02PointInRectangle
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(params int[] coordinates)
        {
            this.X = coordinates[0];
            this.Y = coordinates[1];
        }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
