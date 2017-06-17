using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int i = 0;
            while (nums.Length > 1)
            {
                int[] condensed = new int[nums.Length - 1];
                condensed[i % nums.Length] = (nums[i % nums.Length] + nums[(i + 1) % nums.Length]);
                nums[i % nums.Length] = condensed[i % nums.Length];
                i++;
            }
        }
    }
}
