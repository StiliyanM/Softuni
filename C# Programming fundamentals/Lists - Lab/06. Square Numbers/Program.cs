using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ' ' };
            List<int> nums = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> squareNumbers = new List<int>();

            foreach (var item in nums)
            {
                if(Math.Sqrt(item) == (int) Math.Sqrt(item))
                {
                    squareNumbers.Add(item);
                }
            }

            squareNumbers.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
