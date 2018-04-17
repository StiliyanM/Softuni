using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SquaresinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsAndColumns = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var matrix = new char[rowsAndColumns[0], rowsAndColumns[1]];

            var squaresCounter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var values = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = values[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    var squareElements = new HashSet<char>
                    {
                        matrix[i, j],
                        matrix[i, j + 1],
                        matrix[i + 1, j],
                        matrix[i + 1, j + 1]
                    };

                    if (squareElements.Count == 1)
                    {
                        squaresCounter++;
                    }
                }
            }

            Console.WriteLine(squaresCounter);
        }
    }
}
