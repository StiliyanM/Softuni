using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.Crossfire
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine()
                .Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var rows = dimensions[0];
            var columns = dimensions[1];

            var matrix = new List<List<int>>();

            var counter = 1;
            for (int row = 0; row < rows; row++)
            {
                var line = new List<int>();
                for (int col = 0; col < columns; col++)
                {
                    line.Add(counter);
                    counter++;
                }
                matrix.Add(line);
            }

            var command = Console.ReadLine();

            while (command != "Nuke it from orbit")
            {
                var blast = command.Split().Select(int.Parse).ToArray();

                var inputRow = blast[0];
                var inputColumn = blast[1];
                var radius = blast[2];

                for (int row = inputRow - radius; row <= inputRow + radius; row++)
                {
                    if (row < 0 || row >= matrix.Count)
                    {
                        continue;
                    }

                    if (row == inputRow)
                    {
                        for (int col = inputColumn + radius; col >= inputColumn - radius; col--)
                        {
                            if (col < 0 || col >= matrix[row].Count)
                            {
                                continue;
                            }
                            matrix[row].RemoveAt(col);
                        }
                    }
                    else
                    {
                        if (inputColumn < 0 || inputColumn >= matrix[row].Count)
                        {
                            continue;
                        }
                        matrix[row].RemoveAt(inputColumn);
                    }
                }

                    for (int i = 0; i < matrix.Count; i++)
                    {
                        if(matrix[i].Count == 0)
                        {
                            matrix.RemoveAt(i);
                        }
                    }
                command = Console.ReadLine();
            }

            for (int i = 0; i < matrix.Count; i++)
            {
                if(matrix[i].Count > 0)
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}
