using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] firstArr = new int[arr.Length / 2];
            int[] secondArr = new int[arr.Length / 2];

            int iterator = 0;
            for (int i = 0; i < arr.Length / 4; i++)
            {
                firstArr[i] = arr[i];
                iterator = i;
            }


            for (int i = arr.Length / 4 + arr.Length / 2; i < arr.Length ; i++)
            {
                firstArr[iterator + 1] = arr[i];
                iterator++;
            }

            iterator = 0;
            for (int i = arr.Length / 4; i < (arr.Length / 4 + arr.Length/2); i++)
            {
                secondArr[iterator] = arr[i];

                iterator++;
            }

            Array.Reverse(firstArr, 0, firstArr.Length / 2);
            Array.Reverse(firstArr, firstArr.Length / 2, firstArr.Length / 2);

            for (int i = 0; i < firstArr.Length; i++)
            {
                Console.Write(firstArr[i] + secondArr[i]);
                Console.Write(" ");
            }
        }
    }
}
