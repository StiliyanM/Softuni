using System;
using System.Linq;

namespace P02JediGalaxy
{
    class Program
    {
        static int[][] matrix;
        static long finalSum = 0;

        static int ivoRow;
        static int ivoCol;
        static int evilRow;
        static int evilCol;
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var rows = dimensions[0];
            var columns = dimensions[1];

            matrix = FillMatrix(rows, columns);

            string command;

            while ((command = Console.ReadLine()) != "Let the Force be with you")
            {
                var ivoCoordinates = command.Split().Select(int.Parse).ToArray();

                var evilCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();

                ivoRow = ivoCoordinates[0];
                ivoCol = ivoCoordinates[1];

                evilRow = evilCoordinates[0];
                evilCol = evilCoordinates[1];

                while (evilRow >= 0)
                {
                    if (InsideMatrix(evilRow, evilCol))
                    matrix[evilRow][evilCol] = 0;

                    evilRow--;
                    evilCol--;
                }

                while (ivoRow >= 0)
                {
                    if (InsideMatrix(ivoRow, ivoCol))
                        finalSum += matrix[ivoRow][ivoCol];

                    ivoRow--;
                    ivoCol++;
                }


            }

            Console.WriteLine(finalSum);
        }

        private static bool InsideMatrix(int row, int col)
        {
            var rowInBounds = row >= 0 && row < matrix.Length;
            var colInBounds = col >= 0 && col < matrix[0].Length;

            return rowInBounds && colInBounds;
        }

        private static int[][] FillMatrix(int rows, int columns)
        {
            var matrix = new int[rows][];

            var filler = 0;
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[columns];
                for (int col = 0; col < columns; col++)
                {
                    matrix[row][col] = filler;
                    filler++;
                }
            }
            return matrix;
        }
    }
}
