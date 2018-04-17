using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _5.RubiksMatrix
{
    class Program
    {
        private static int[][] matrix = new int[1][];

        private static int rows = 0;
        private static int cols = 0;

        static void Main(string[] args)
        {
            var rowsAndColumns = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            rows = rowsAndColumns[0];
            cols = rowsAndColumns[1];

            matrix = new int[rows][];

            var filler = 1;

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = filler++;
                }
            }

            var commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var direction = input[1];

                var moves = int.Parse(input[2]);
                
                if (direction == "left" || direction == "right")
                {
                    var row = int.Parse(input[0]);

                    matrix[row] = ShiftArray(matrix[row], direction, moves);
                }
                else if (direction == "up" || direction == "down")
                {
                    var col = int.Parse(input[0]);

                    var arrayToShift = new int[rows];

                    for (int j = 0; j < rows; j++)
                    {
                        arrayToShift[j] = matrix[j][col];
                    }

                    arrayToShift = ShiftArray(arrayToShift, direction, moves);

                    for (int j = 0; j < rows; j++)
                    {
                        matrix[j][col] = arrayToShift[j];
                    }
                }
            }

            RearrangeMatrix(matrix);
        }

        private static void RearrangeMatrix(int[][] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    var startingValue = row * cols + (col + 1);

                    var currentValue = matrix[row][col];

                    if(startingValue != currentValue)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            var currentRow = matrix[i];

                            var index = Array.IndexOf(currentRow, startingValue);

                            if(index != -1)
                            {
                                matrix[i][index] = currentValue;
                                matrix[row][col] = startingValue;

                                Console.WriteLine($"Swap ({row}, {col}) with ({i}, {index})");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No swap required");
                    }
                }
            }
        }

        private static int[] ShiftArray(int[] array, string direction, int moves)
        {
            var queue = new Queue<int>(array);

            if (direction == "right" || direction == "down")
            {
                queue = new Queue<int>(array.Reverse());

                for (int i = 0; i < moves % queue.Count; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                array = queue.Reverse().ToArray();
            }
            else
            {
                for (int i = 0; i < moves % queue.Count; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                array = queue.ToArray();
            }

            return array;
        }
    }
}
