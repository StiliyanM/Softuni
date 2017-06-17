using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Summ_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int max = Math.Max(arr1.Length, arr2.Length);

            int[] arr3 = new int[max];

            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i % max] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }

            Console.WriteLine(string.Join(" ", arr3));
        }
    }
}
