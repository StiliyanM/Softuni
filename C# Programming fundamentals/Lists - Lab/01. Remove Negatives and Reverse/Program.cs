using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> absNums = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                    absNums.Add(numbers[i]);
            }

            absNums.Reverse();

            if(absNums.Count > 1)
            Console.WriteLine(string.Join(" ", absNums));
            else
            {
                Console.WriteLine("empty");
            }  
        }
    }
}
