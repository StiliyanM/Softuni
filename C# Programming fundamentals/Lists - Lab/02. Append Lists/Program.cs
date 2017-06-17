using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charSeparators = new char[] { ' '};

            List<string> numbers = Console.ReadLine().Split('|').ToList();

            List <int> result = new List<int>();

            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                List<int> token = numbers[i].Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                if (numbers[i].Length > 0)
                {
                    foreach (var item in token)
                    {
                        result.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
