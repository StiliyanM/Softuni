using System;

namespace P15DrawingTool
{
    class Square : Figure
    {
        public int Side { get; set; }

        public override void Draw()
        {
            var dashes = new string('-', Side);
            var spaces = new string(' ', Side);

            for (int i = 0; i < Side; i++)
            {
                Console.Write("|");

                if(i == 0 || i == Side - 1)
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
