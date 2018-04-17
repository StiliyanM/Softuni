using System;
using System.Linq;

namespace _11.ParkingSystem
{
    class Program
    {
        static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var rows = dimensions[0];
            var columns = dimensions[1];

            var carPool = new bool[rows][];

            string command;

            while ((command = Console.ReadLine()) != "stop")
            {
                var tokens = command.Split().Select(int.Parse).ToArray();

                var startingRow = tokens[0];
                var desiredRow = tokens[1];
                var desiredCol = tokens[2];

                if (carPool[desiredRow] == null)
                    carPool[desiredRow] = new bool[columns];

                if (IsSpotFree(carPool, desiredRow, desiredCol))
                {
                    carPool[desiredRow][desiredCol] = true;
                    Console.WriteLine(GetDistance(carPool, desiredRow, desiredCol, startingRow));
                    continue;
                }

                var newCol = -1;
                var maxDistance = int.MaxValue;

                for (int col = 1; col < columns; col++)
                {
                    if (!IsSpotFree(carPool, desiredRow, col))
                    {
                        continue;
                    }

                    var distance = Math.Abs(col - desiredCol);
                    if (distance < maxDistance)
                    {
                        maxDistance = distance;
                        newCol = col;
                    }

                }

                if (newCol < 0)
                {
                    Console.WriteLine($"Row {desiredRow} full");
                }
                else
                {
                    carPool[desiredRow][newCol] = true;
                    Console.WriteLine(GetDistance(carPool, desiredRow, newCol, startingRow));
                }
            }
        }

        private static int GetDistance(bool[][] carPool, int row, int col, int startingRow)
        {
            return col + 1 + Math.Abs(row - startingRow);
        }

        private static bool IsSpotFree(bool[][] matrix, int row, int col)
        {
            return matrix[row][col] == false;
        }
    }
}
