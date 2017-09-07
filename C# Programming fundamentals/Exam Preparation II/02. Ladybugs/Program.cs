using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var indexes = Console.ReadLine().Split().Select(int.Parse).
                Where(a => a >= 0 && a < size)
                .ToArray();

            var field = new int[size];

            for (int i = 0; i < field.Length; i++)
            {
                if(indexes.Contains(i))
                {
                    field[i] = 1;
                }
            }

            while (true)
            {
                var tokens = Console.ReadLine().Split();

                if(tokens[0] == "end")
                {
                    break;
                }

                int ladybugIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int length = int.Parse(tokens[2]);

                if(ladybugIndex < 0 || ladybugIndex >= field.Length || field[ladybugIndex] == 0)
                {
                    continue;
                }

                if (direction == "left")
                {
                    length = -length;
                }

                int jumpedToIndex = ladybugIndex;
                field[ladybugIndex] = 0;

                while (true)
                {
                    jumpedToIndex += length;

                    if (jumpedToIndex >= field.Length || jumpedToIndex < 0)
                    {
                        break;
                    }
                    if(field[jumpedToIndex] == 0)
                    {
                        field[jumpedToIndex] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",field));
        }
    }
}
