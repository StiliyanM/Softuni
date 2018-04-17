using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];

            int[,] matrix = InitializeMatrix(rows, columns);

            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] ivoS = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] evil = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int evilRow = evil[0];
                int evilCol = evil[1];

                while (evilRow >= 0)
                {
                    if (InBounds(matrix, evilRow, evilCol))
                    {
                        matrix[evilRow, evilCol] = 0;
                    }
                    evilRow--;
                    evilCol--;
                }

                int ivoRow = ivoS[0];
                int ivoCol = ivoS[1];

                while (ivoRow >= 0)
                {
                    if (InBounds(matrix, ivoRow, ivoCol))
                    {
                        sum += matrix[ivoRow, ivoCol];
                    }

                    ivoCol++;
                    ivoRow--;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);

        }

        private static bool InBounds(int[,] matrix, int row, int col)
        {
            bool rowInBounds = row >= 0 && row < matrix.GetLength(0);
            bool colInBounds = col >= 0 && col < matrix.GetLength(1);
            return rowInBounds && colInBounds;
        }

        private static int[,] InitializeMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];

            int value = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = value++;
                }
            }

            return matrix;
        }
    }
}
