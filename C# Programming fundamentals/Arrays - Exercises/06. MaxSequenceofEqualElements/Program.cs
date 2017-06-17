using System;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


        int endNum = 0;
        int len = 1;
        int endlen = 1;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if(array[i] == array[i + 1])
            {
                len++;

                if(len > endlen)
                {
                    endlen = len;
                    endNum = array[i];
                }
            }
            else
            {
                len = 1;
            }
        }
        for (int i = 0; i < endlen; i++)
        {
            Console.Write(endNum + " ");
        }
    }
}