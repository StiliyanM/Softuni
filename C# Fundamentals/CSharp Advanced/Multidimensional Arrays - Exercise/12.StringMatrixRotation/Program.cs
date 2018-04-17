using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.StringMatrixRotation
{
    class Program
    {
        static int columns = 0;
        static int rows = 0;
        static char[][] resultMatrix;
        static void Main()
        {
            var rotationString = Console.ReadLine();

            var degreesString = new StringBuilder();
            for (int i = 0; i < rotationString.Length; i++)
            {
                if (char.IsDigit(rotationString[i]))
                    degreesString.Append(char.GetNumericValue(rotationString[i]));
            }

            var degrees = int.Parse(degreesString.ToString()) % 360;

            var queue = new Queue<string>();
            string lines;

            var maxLengthColumn = 0;
            while ((lines = Console.ReadLine()) != "END")
            {
                queue.Enqueue(lines);
                rows++;
                if(lines.Length > maxLengthColumn)
                {
                    maxLengthColumn = lines.Length;
                }
            }

            columns = maxLengthColumn;

            var matrix = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                var characters = queue.Dequeue().ToArray();
                matrix[row] = new char[columns];
                for (int col = 0; col < columns; col++)
                {
                    if (col < characters.Length)
                        matrix[row][col] = characters[col];
                    else
                        matrix[row][col] = ' ';
                }
            }

            resultMatrix = new char[matrix.Length][];

            switch (degrees)
            {
                case 0:
                case 360:
                    Print(matrix);
                    break;
                case 90:
                    Rotate90(matrix);
                    Print(resultMatrix);
                    break;
                case 180:
                    Rotate180(matrix);
                    Print(resultMatrix);
                    break;
                case 270:
                    Rotate270(matrix);
                    Print(resultMatrix);
                    break;
            }
        }

        private static void Rotate270(char[][] matrix)
        {
            resultMatrix = new char[matrix[0].Length][];

            for (int row = 0; row < resultMatrix.Length; row++)
            {
                var matrixCol = resultMatrix.Length - 1 - row;
                resultMatrix[row] = new char[rows];

                for (int col = 0; col < resultMatrix[row].Length; col++)
                {
                    var matrixRow = col;
                    resultMatrix[row][col] = matrix[matrixRow][matrixCol];
                }
            }
        }

        private static void Rotate180(char[][] matrix)
        {
            resultMatrix = new char[matrix.Length][];

            for (int row = 0; row < resultMatrix.Length; row++)
            {
                var matrixCol = resultMatrix.Length - 1 - row;
                resultMatrix[row] = new char[columns];

                for (int col = 0; col < resultMatrix[row].Length; col++)
                {
                    var matrixRow = resultMatrix[row].Length - 1 - col;
                    resultMatrix[row][col] = matrix[matrixCol][matrixRow];
                }
            }
        }

        private static void Rotate90(char[][] matrix)
        {
            resultMatrix = new char[matrix[0].Length][];

            for (int row = 0; row < resultMatrix.Length; row++)
            {
                var matrixCol = row;
                resultMatrix[row] = new char[rows];

                for (int col = 0; col < resultMatrix[row].Length; col++)
                {
                    var matrixRow = resultMatrix[row].Length - 1 - col;
                    resultMatrix[row][col] = matrix[matrixRow][matrixCol];
                }
            }

        }

        private static void Print(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join("", matrix[i]));
            }
        }

    }
}
