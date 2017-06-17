using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr = Console.ReadLine();

            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine($"{arr[i]} -> {arr[i] - 97}");
            }
        }
    }
}
