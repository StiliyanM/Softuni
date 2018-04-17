using System;

namespace P01RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                PrintRow(size,i);
            }

            for (int i = size - 1; i > 0; i--)
            {
                PrintRow(size,i);
            }
        }

        private static void PrintRow(int size, int row)
        {
            var spaces = new string(' ', size - row);

            Console.Write(spaces);
            for (int i = 0; i < row; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
