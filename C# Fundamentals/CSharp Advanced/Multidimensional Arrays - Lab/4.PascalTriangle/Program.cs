using System;

namespace _4.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            var triangle = new long[rows][];

            var currentWidth = 1;

            for (int i = 0; i < rows; i++)
            {
                triangle[i] = new long[currentWidth];

                triangle[i][0] = 1;
                triangle[i][currentWidth - 1] = 1;

                for (int j = 1; j < currentWidth - 1; j++)
                {
                    triangle[i][j] = triangle[i - 1][j] + triangle[i - 1][j - 1];
                }

                currentWidth++;
            }

            for (int i = 0; i < triangle.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(" ",triangle[i]));
            }
        }
    }
}
