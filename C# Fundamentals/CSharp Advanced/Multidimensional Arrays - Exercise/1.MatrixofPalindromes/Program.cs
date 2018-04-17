using System;
using System.Linq;

namespace _1.MatrixofPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var rows = input[0];

            var colums = input[1];

            var matrix = new string[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    matrix[i, j] = 
                        alphabet[i].ToString() + alphabet[i + j].ToString() + alphabet[i].ToString();
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
