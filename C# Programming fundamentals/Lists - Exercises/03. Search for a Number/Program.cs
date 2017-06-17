using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int takeCnt = arr[0];
            int deleteCnt = arr[1];
            int wantedNum = arr[2];

            nums.Take(takeCnt);
            nums.RemoveRange(0, deleteCnt);

            if(nums.Contains(wantedNum))
                Console.WriteLine("YES!");
            else
                Console.WriteLine("NO!");
        }
    }
}
