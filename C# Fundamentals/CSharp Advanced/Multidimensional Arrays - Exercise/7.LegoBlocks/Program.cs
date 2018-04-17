using System;
using System.Linq;

namespace _7.LegoBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());

            var first = new int[rows][];
            var second = new int[rows][];

            var count = 0;

            for (int row = 0; row < rows; row++)
            {
                first[row] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                count += first[row].Length;
            }
            for (int row = 0; row < rows; row++)
            {
                second[row] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                count += second[row].Length;
            }

            var length = first[0].Length + second[0].Length;

            for (int i = 0; i < rows; i++)
            {
                if (first[i].Length + second[i].Length != length)
                {
                    Console.WriteLine($"The total number of cells is: {count}");
                    return;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(
                    "[{0}, {1}]", string.Join(", ", first[i]), string.Join(", ", second[i].Reverse()));
            }
        }
    }
}
