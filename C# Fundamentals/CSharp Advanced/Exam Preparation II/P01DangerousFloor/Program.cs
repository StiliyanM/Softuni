using System;
using System.Linq;

namespace P01DangerousFloor
{
    class Program
    {
        static char[][] board;
        static void Main(string[] args)
        {
            board = new char[8][];

            for (int i = 0; i < 8; i++)
            {
                board[i] = Console.ReadLine().Split(',').Select(char.Parse).ToArray();
            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                var piece = command.First();

                var currentRow = (int)char.GetNumericValue(command[1]);
                var currentCol = (int)char.GetNumericValue(command[2]);
                var desiredRow = (int)char.GetNumericValue(command[4]);
                var desiredCol = (int)char.GetNumericValue(command[5]);

                if (!PieceExists(currentRow, currentCol, piece))
                {
                    Console.WriteLine("There is no such a piece!");
                    continue;
                }

                var rowDiff = Math.Abs(desiredRow - currentRow);
                var colDiff = Math.Abs(desiredCol - currentCol);

                bool validMove;
                try
                {
                    switch (piece)
                    {
                        case 'K':
                            validMove = !(rowDiff > 1 || colDiff > 1);
                            TryMove(validMove, currentRow, currentCol, desiredRow, desiredCol, piece);
                            break;
                        case 'R':
                            validMove = (colDiff == 0 && rowDiff != 0) || (colDiff != 0 && rowDiff == 0);
                            TryMove(validMove, currentRow, currentCol, desiredRow, desiredCol, piece);
                            break;
                        case 'B':
                            validMove = rowDiff == colDiff;
                            TryMove(validMove, currentRow, currentCol, desiredRow, desiredCol, piece);
                            break;
                        case 'Q':
                            validMove = rowDiff == colDiff || (colDiff == 0 && rowDiff != 0) || (colDiff != 0 && rowDiff == 0);
                            TryMove(validMove, currentRow, currentCol, desiredRow, desiredCol, piece);
                            break;
                        case 'P':
                            validMove = currentCol == desiredCol && desiredRow == currentRow - 1;
                            TryMove(validMove, currentRow, currentCol, desiredRow, desiredCol, piece);
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Move go out of board!");
                }
            }
        }

        private static void TryMove(bool validMove, int currentRow, int currentCol, int desiredRow, int desiredCol, char piece)
        {
            if (!validMove)
            {
                Console.WriteLine("Invalid move!");
                return;
            }

            if (!PieceExists(desiredRow, desiredCol, 'x'))
            {
                Console.WriteLine("Invalid move!");
                return;
            }
            MovePiece(currentRow, currentCol, desiredRow, desiredCol, piece);
        }

        private static void MovePiece(int currentRow, int currentCol, int desiredRow, int desiredCol, char piece)
        {
            board[currentRow][currentCol] = 'x';
            board[desiredRow][desiredCol] = piece;
        }

        private static bool PieceExists(int row, int col, char piece)
        {
            return board[row][col] == piece;
        }
    }
}
