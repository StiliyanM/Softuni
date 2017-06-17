using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int number = 0;
            int cnt = 1;
            int bestCount = 1;
            int bestNum = numbers[0];
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if(numbers[i] == numbers[i + 1])
                {
                    number = numbers[i];
                    cnt++;
                    if(cnt > bestCount)
                    {
                        bestCount = cnt;
                        bestNum = number;
                    }
                }
                else
                {
                    cnt = 1;
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(bestNum + " ");
            }
        }
    }
}
