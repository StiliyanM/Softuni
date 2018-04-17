namespace P15DrawingTool
{
    class DrawingTool
    {
        public Figure Figure { get; set; }

        public DrawingTool(Figure figure)
        {
            figure.Draw();
        }

        public DrawingTool()
        {

        }
    }
}
