using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int checker = 0;
            for (int i = 0; i < Math.Min(arr1.Length,arr2.Length); i++)
            {
                if (arr1[i] == arr2[i])
                    continue;

                if (arr1[i] > arr2[i])
                {
                    checker++;
                    break;
                }
                else if(arr2[i] > arr1[i])
                {
                    break;
                }


            }
            if (arr1.Length > arr2.Length)
                checker++;

            if (checker == 0)
            {
                foreach (var item in arr1)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
                foreach (var item in arr2)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
            else
            {
                foreach (var item in arr2)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
                foreach (var item in arr1)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }

        }
    }
}
