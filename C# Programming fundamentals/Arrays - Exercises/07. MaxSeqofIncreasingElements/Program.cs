using System;
using System.Linq;

class MaxSeqofIncreasingElements
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int len = 1;
        int endlen = 1;
        int startIndex = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                len++;

                if (len > endlen)
                {
                    endlen = len;
                    startIndex = i + 2 - len;
                }
            }
            else
            {
                len = 1;
            }
        }
        for (int i = startIndex; i < startIndex + endlen; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}