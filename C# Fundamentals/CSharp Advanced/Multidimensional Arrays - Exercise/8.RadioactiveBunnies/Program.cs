using System;
using System.Linq;

namespace _8.RadioactiveBunnies
{
    class Program
    {
        static char[][] matrix;
        static int rows = 0;
        static int columns = 0;
        static bool isDead = false;
        static bool isGameOver = false;

        static char[][] resultingMatrix;
        static int playerRow = 0;
        static int playerCol = 0;
        static void Main(string[] args)
        {
            var rowsAndColumns = Console.ReadLine().Split().Select(int.Parse).ToArray();

            rows = rowsAndColumns[0];
            columns = rowsAndColumns[1];

            matrix = new char[rows][];
            resultingMatrix = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            var commands = Console.ReadLine();

            for (int i = 0; i < commands.Length; i++)
            {
                var direction = commands[i];

                Array.Copy(matrix, resultingMatrix, matrix.Length);

                MovePlayer(direction);

                SpreadBunnies();

                Array.Copy(resultingMatrix, matrix, resultingMatrix.Length);
                if (isGameOver)
                    PrintResults(playerRow,playerCol);
            }
        }

        private static void SpreadBunnies()
        {
            for (int row = 1; row < rows - 1; row++)
            {
                for (int col = 1; col < columns - 1; col++)
                {
                    if (matrix[row][col] != 'B')
                    {
                        continue;
                    }

                    bool isPlayerAbove = matrix[row - 1][col] == 'P';
                    bool isPlayerBelow = matrix[row + 1][col] == 'P';
                    bool isPlayerToTheLeft = matrix[row][col - 1] == 'P';
                    bool isPlayerToTheRight = matrix[row][col + 1] == 'P';

                    bool isPlayerKilled = isPlayerBelow || isPlayerAbove ||
                                            isPlayerToTheLeft || isPlayerToTheRight;

                    if (isPlayerKilled)
                    {
                        isDead = true;
                        isGameOver = true;
                    }

                    resultingMatrix[row + 1][col] = 'B';
                    resultingMatrix[row - 1][col] = 'B';
                    resultingMatrix[row][col + 1] = 'B';
                    resultingMatrix[row][col - 1] = 'B';

                    if (isGameOver)
                        return;
                }
            }
        }

        private static void MovePlayer(char direction)
        {
            for (int row = 0; row < rows; row++)
            {
                var indexOfPlayer = Array.IndexOf(matrix[row], 'P');

                if (indexOfPlayer == -1)
                {
                    continue;
                }

                playerRow = row;
                playerCol = indexOfPlayer;
            }
            switch (direction)
            {
                case 'L':
                    MoveLeft(playerRow, playerCol);
                    break;
                case 'R':
                    MoveRight(playerRow, playerCol);
                    break;
                case 'U':
                    MoveUp(playerRow, playerCol);
                    break;
                case 'D':
                    MoveDown(playerRow, playerCol);
                    break;
            }
        }

        private static void PrintResults(int playerRow, int playerCol)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }

            if (isDead)
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            else
                Console.WriteLine($"won: {playerRow} {playerCol}");

            Environment.Exit(0);
        }

        private static void MoveDown(int playerRow, int playerCol)
        {
            var isInside = playerRow + 1 < rows;

            if (!isInside)
            {
                isGameOver = true;
                return;
            }

            if (matrix[playerRow + 1][playerCol] == 'B')
            {
                isGameOver = true;
                isDead = true;
                return;
            }

            matrix[playerRow + 1][playerCol] = 'P';
            matrix[playerRow][playerCol] = '.';
        }

        private static void MoveUp(int playerRow, int playerCol)
        {
            var isInside = playerRow - 1 >= 0;

            if (!isInside)
            {
                isGameOver = true;
                return;
            }

            if (matrix[playerRow - 1][playerCol] == 'B')
            {
                isGameOver = true;
                isDead = true;
                return;
            }

            matrix[playerRow - 1][playerCol] = 'P';
            matrix[playerRow][playerCol] = '.';
        }

        private static void MoveRight(int playerRow, int playerCol)
        {
            var isInside = playerCol + 1 < columns;

            if (!isInside)
            {
                isGameOver = true;
                return;
            }

            if (matrix[playerRow][playerCol + 1] == 'B')
            {
                isGameOver = true;
                isDead = true;
                return;
            }

            matrix[playerRow][playerCol + 1] = 'P';
            matrix[playerRow][playerCol] = '.';

        }

        private static void MoveLeft(int playerRow, int playerCol)
        {
            var isInside = playerCol - 1 >= 0;

            if (!isInside)
            {
                isGameOver = true;
                return;
            }

            if (matrix[playerRow][playerCol - 1] == 'B')
            {
                isGameOver = true;
                isDead = true;
                return;
            }

            matrix[playerRow][playerCol - 1] = 'P';
            matrix[playerRow][playerCol] = '.';
        }
    }
}
