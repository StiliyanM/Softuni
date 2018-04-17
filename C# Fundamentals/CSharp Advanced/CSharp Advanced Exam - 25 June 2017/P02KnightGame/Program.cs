using System;

namespace P02KnightGame
{
    class Program
    {
        static char[][] table = new char[1][];
        static void Main()
        {
            var rows = int.Parse(Console.ReadLine());

            table = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                table[i] = Console.ReadLine().ToCharArray();
            }

            var removedCount = 0;

            while (true)
            {
                var maxAttackCounter = 0;
                int deleteRow = -1;
                int deleteCol = -1;

                var isGameOver = CheckIfGameIsOver();

                if (isGameOver)
                {
                    break;
                }
                for (int row = 0; row < table.Length; row++)
                {
                    for (int col = 0; col < table[row].Length; col++)
                    {
                        if (table[row][col] == 'K')
                        {
                            var attackCounter = GetAttackCounter(row, col);

                            if (attackCounter > maxAttackCounter)
                            {
                                maxAttackCounter = attackCounter;
                                deleteRow = row;
                                deleteCol = col;
                            }
                        }
                    }               
                }

                if (IsAKnight(deleteRow, deleteCol))
                {
                    table[deleteRow][deleteCol] = '0';
                    removedCount++;
                }
            }

            Console.WriteLine(removedCount);

        }

        private static bool CheckIfGameIsOver()
        {
            for (int row = 0; row < table.Length; row++)
            {
                for (int col = 0; col < table[row].Length; col++)
                {
                    if (table[row][col] == 'K')
                    {
                        var attackCounter = GetAttackCounter(row, col);
                        if(attackCounter != 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private static int GetAttackCounter(int row, int col)
        {
            var counter = 0;

           if(IsAKnight(row - 2, col - 1))
            {
                counter++;
            }
            if (IsAKnight(row + 2, col + 1))
            {
                counter++;
            }
            if (IsAKnight(row - 2, col + 1))
            {
                counter++;
            }
            if (IsAKnight(row + 2, col - 1))
            {
                counter++;
            }

            if (IsAKnight(row - 1, col - 2))
            {
                counter++;
            }
            if (IsAKnight(row + 1, col + 2))
            {
                counter++;
            }
            if (IsAKnight(row - 1, col + 2))
            {
                counter++;
            }
            if (IsAKnight(row + 1, col - 2))
            {
                counter++;
            }

            return counter;
        }

        private static bool IsAKnight(int row, int col)
        {
            if(row < 0 || row >= table.Length)
            {
                return false;
            }
            if(col < 0 || col >= table[row].Length)
            {
                return false;
            }

            var element = table[row][col];

            if(element == 'K')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
