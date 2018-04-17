using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                            .Split(new string[] { ", " }, StringSplitOptions.None)
                            .Select(int.Parse).ToArray();

            var jaggedArray = new int[3][];

            var remainder0 = new List<int>();
            var remainder1 = new List<int>();
            var remainder2 = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var remainder = Math.Abs(numbers[i] % 3);
                if(remainder == 0)
                {
                    remainder0.Add(numbers[i]);
                }
                else if (remainder == 1)
                {
                    remainder1.Add(numbers[i]);
                }
                else if (remainder == 2)
                {
                    remainder2.Add(numbers[i]);
                }
            }

            jaggedArray[0] = remainder0.ToArray();
            jaggedArray[1] = remainder1.ToArray();
            jaggedArray[2] = remainder2.ToArray();

            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(" ",jaggedArray[i]));
            }
        }
    }
}
