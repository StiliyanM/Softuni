using System;
using System.Collections.Generic;
using System.Linq;

class ByteFlip
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split().ToList();

        List<string> neededInput = new List<string>();

        for (int index = 0; index < input.Count; index++)
        {
            if (input[index].Length == 2)
            {
                neededInput.Add(input[index]);
            }
        }

        List<string> numbersInHec = new List<string>();
        List<char> numbers = new List<char>();

        for (int index = 0; index < neededInput.Count; index++)
        {
            numbers = neededInput[index].ToCharArray().ToList();
            string revesedNum = numbers[1] + "" + numbers[0];
            numbersInHec.Add(revesedNum);
        }
        numbersInHec.Reverse();

        List<int> numbersInDec = new List<int>();

        for (int index = 0; index < numbersInHec.Count; index++)
        {
            int decValue = Convert.ToInt32(numbersInHec[index], 16);
            numbersInDec.Add(decValue);
        }

        for (int index = 0; index < numbersInDec.Count; index++)
        {
            Console.Write((char)numbersInDec[index]);
        }
        Console.WriteLine();
    }
}