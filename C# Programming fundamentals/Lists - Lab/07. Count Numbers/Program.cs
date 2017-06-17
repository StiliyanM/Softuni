using System;
using System.Collections.Generic;
using System.Linq;

class CountNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        numbers.Sort();
        int counter = 1;

        for (int index = 0; index < numbers.Count - 1; index++)
        {
            if (numbers[index] == numbers[index + 1])
            {
                counter++;
            }
            if (numbers[index] != numbers[index + 1])
            {
                Console.WriteLine($"{numbers[index]} -> {counter}");
                counter = 1;
            }
        }
        Console.WriteLine($"{numbers[numbers.Count - 1]} -> {counter}");
    }
}