using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();


            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();

                if (command[0] == "END")
                    break;

                if (command[0] == "Reverse")
                {
                    Array.Reverse(arr);
                }
                else if (command[0] == "Distinct")
                {
                    arr = arr.Distinct().ToArray();
                }
                else if (command[0] == ("Replace"))
                {
                    int index = int.Parse(command[1]);
                    string stringReplacement = command[2];

                    if ((index < 0 || index >= arr.Length))
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    arr[index] = stringReplacement;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }


            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
