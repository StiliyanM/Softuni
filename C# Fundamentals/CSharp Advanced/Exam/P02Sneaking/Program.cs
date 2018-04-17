using System;
namespace P02Sneaking
{
    class Program
    {
        static char[][] room;
        static int samRow = 0;
        static int samCol = 0;
        static int nikoladzeRow = 0;
        static int nikoladzeCol = 0;
        static bool samWin = false;

        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            IntitializeMatrix(size);

            var moves = Console.ReadLine();

            foreach (var move in moves)
            {
                MoveEnemies();

                if (IsSamKilled())
                {
                    room[samRow][samCol] = 'X';
                    break;
                }
                
                MoveSam(move);

                if (samRow == nikoladzeRow)
                {
                    samWin = true;
                    room[nikoladzeRow][nikoladzeCol] = 'X';
                    break;
                }
            }

            if (samWin)
            {
                Console.WriteLine("Nikoladze killed!");
            }
            else
            {

                Console.WriteLine($"Sam died at {samRow}, {samCol}");
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(string.Join("", room[i]));
            }
        }

        private static void IntitializeMatrix(int size)
        {
            room = new char[size][];

            for (int row = 0; row < size; row++)
            {
                var array = Console.ReadLine().ToCharArray();

                room[row] = new char[array.Length];

                for (int col = 0; col < array.Length; col++)
                {
                    room[row][col] = array[col];
                    if (room[row][col] == 'S')
                    {
                        samRow = row;
                        samCol = col;
                    }
                    if (room[row][col] == 'N')
                    {
                        nikoladzeRow = row;
                        nikoladzeCol = col;
                    }
                }
            }

        }

        private static bool IsSamKilled()
        {
            var enemyIndex = Array.IndexOf(room[samRow], 'b');

            if (enemyIndex == -1)
            {
                enemyIndex = Array.IndexOf(room[samRow], 'd');

                if (enemyIndex == -1)
                {
                    return false;
                }
            }

            var enemy = room[samRow][enemyIndex];

            var samToTheRight = enemy == 'b' && enemyIndex < samCol;
            var samToTheLeft = enemy == 'd' && enemyIndex > samCol;

            if (samToTheLeft || samToTheRight)
            {
                return true;
            }

            return false;
        }

        private static void MoveSam(char move)
        {
            room[samRow][samCol] = '.';
            switch (move)
            {
                case 'U':
                    samRow--;
                    break;
                case 'D':
                    samRow++;
                    break;
                case 'L':
                    samCol--;
                    break;
                case 'R':
                    samCol++;
                    break;
                case 'W':
                    break;
            }
            room[samRow][samCol] = 'S';
        }

        private static void MoveEnemies()
        {
            for (int row = 0; row < room.Length; row++)
            {
                var indexOfB = Array.IndexOf(room[row], 'b');
                var indexOfD = Array.IndexOf(room[row], 'd');

                if (indexOfB != -1)
                {
                    if (indexOfB + 1 < room[row].Length)
                    {
                        room[row][indexOfB] = '.';
                        room[row][indexOfB + 1] = 'b';
                    }
                    else
                    {
                        room[row][indexOfB] = 'd';
                    }
                }
                if (indexOfD != -1)
                {
                    if(indexOfD - 1 >= 0)
                    {
                        room[row][indexOfD] = '.';
                        room[row][indexOfD - 1] = 'd';
                    }
                    else
                    {
                        room[row][indexOfD] = 'b';
                    }
                }
            }
        }
    }
}
