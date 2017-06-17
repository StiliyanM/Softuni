using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();

            int equalLeftCnt = 0;
            int equalRightCnt = 0;
            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if(arr1[i] == arr2[i])
                {
                    equalLeftCnt++;
                }
            }

            Array.Reverse(arr1);
            Array.Reverse(arr2);

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] == arr2[i])
                {
                    equalRightCnt++;
                }
            }

            Console.WriteLine(Math.Max(equalLeftCnt,equalRightCnt));
        }
    }
}
