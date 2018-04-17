using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsAndColumns = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var snake = Console.ReadLine();
            var shot = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var impactRow = shot[0];
            var impactColumn = shot[1];
            var radius = shot[2];

            var rows = rowsAndColumns[0];
            var cols = rowsAndColumns[1];

            var charactersNeeded = rows * cols;

            var queue = new Queue<char>();
            for (int i = 0; i < charactersNeeded; i++)
            {
                queue.Enqueue(snake[i % snake.Length]);
            }

            var matrix = new char[rows, cols];

            var counter = 1;
            for (int i = rows - 1; i >= 0; i--)
            {
                if(counter % 2 == 0)
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = queue.Dequeue();
                }
                else
                    for (int j = cols - 1; j >= 0; j--)
                    {
                        matrix[i, j] = queue.Dequeue();
                    }
                counter++;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    bool isInside = (i - impactRow) * (i - impactRow) + (j - impactColumn) * (j - impactColumn) <= radius * radius;

                    if (isInside)
                    {
                        matrix[i, j] = ' ';
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int i = 0; i < rows - 1; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        var isNextEmpty = matrix[i + 1, j] == ' ';

                        if (isNextEmpty)
                        {
                            matrix[i + 1, j] = matrix[i, j];
                            matrix[i, j] = ' ';
                        }
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
