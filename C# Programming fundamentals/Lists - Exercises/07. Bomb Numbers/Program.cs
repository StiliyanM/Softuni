using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bombNum = bomb[0];
            int power = bomb[1];

            int bombIndex = -1;

            for (int i = 0; i < numbers.Count; i++)
            {
                int LeftIndex = 0;
                int RightIndex = 0;
                bombIndex = i;
                if(numbers[i] == bombNum)
                {
                    LeftIndex = Math.Max(bombIndex - power, 0);
                    RightIndex = Math.Min(numbers.Count - 1, power + bombIndex);

                    int removeCnt = RightIndex - LeftIndex + 1;

                    numbers.RemoveRange(LeftIndex, removeCnt);

                    i = -1;
                }
            }
            Console.WriteLine(numbers.Sum());    
        }
    }
}
