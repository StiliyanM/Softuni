using System;
using System.Linq;

namespace _2.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            var matrix = new int[size, size];

            var primaryDiagonalSum = 0;
            var secondaryDiagonalSum = 0;

            for (int i = 0; i < size; i++)
            {
                var values = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = values[j];

                    if(i == j)
                    {
                        primaryDiagonalSum += values[j];
                    }

                    if(i + j == size - 1)
                    {
                        secondaryDiagonalSum += values[j];
                    }
                }
            }

            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}
