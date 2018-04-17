using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsAndColumns = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                . Select(int.Parse).ToArray();

            var matrix = new int[rowsAndColumns[0], rowsAndColumns[1]];

            var maxSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var values = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = values[j];
                }
            }

            var rowIndex = 0;
            var colIndex = 0;

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    var sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                            matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                            matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if(sum > maxSum)
                    {
                        maxSum = sum;
                        rowIndex = i;
                        colIndex = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int i = rowIndex; i < rowIndex + 3; i++)
            {
                for (int j = colIndex; j < colIndex + 3; j++)
                {
                    Console.Write(matrix[i, j]);

                    if (j != colIndex + 2)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
