using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long i = 0;
            long indices = arr[i];
            long sum = arr[0];
            while (i + indices < arr.Length)
            {
                i += arr[i];
                indices = arr[i];
                sum += indices;
            }
            while (i - indices >= 0)
            {
                i -= indices;
                indices = arr[i];
                sum += indices;
            }

            Console.WriteLine(sum);
        }
    } 
}
