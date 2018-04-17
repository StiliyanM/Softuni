using System;
using System.Linq;

namespace _1._SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSizes = Console.ReadLine()
                .Split(new string[] {", " }, StringSplitOptions.None)
                .Select(int.Parse).ToArray();

            var rows = matrixSizes[0];
            var cols = matrixSizes[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var values = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.None)
                    .Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = values[j];
                }
            }

            var sum = 0;

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            foreach (var element in matrix)
            {
                sum += element;
            }

            Console.WriteLine(sum);
        }
    }
}
