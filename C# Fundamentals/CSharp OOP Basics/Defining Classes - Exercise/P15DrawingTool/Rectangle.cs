using System;

namespace P15DrawingTool
{
    class Rectangle : Figure
    {
        public int Width { get; set; }
        public int Length { get; set; }

        public override void Draw()
        {
            var dashes = new string('-', Width);
            var spaces = new string(' ', Width);

            for (int i = 0; i < Length; i++)
            {
                Console.Write("|");

                if (i == 0 || i == Length - 1)
                {
                    Console.Write(dashes);
                }
                else
                {
                    Console.Write(spaces);
                }

                Console.WriteLine("|");
            }

        }
    }
}
