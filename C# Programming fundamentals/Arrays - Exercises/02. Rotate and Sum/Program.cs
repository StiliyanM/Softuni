using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] sum = new int[arr.Length];

            while (k > 0)
            {
                int[] temp = new int[arr.Length];


                RotateArray(arr, temp);

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = temp[i];
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    sum[i] += temp[i];
                }

                k--;
            }

            foreach (var item in sum)
            {
                Console.Write(item + " ");
            }

        }

        private static void RotateArray(int[] arr, int[] temp)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                temp[(i + 1) % arr.Length] = arr[i % arr.Length];
            }
        }
    }
}
