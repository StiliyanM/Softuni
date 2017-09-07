using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputline = Console.ReadLine().Split();

            int baseOfTheNumber = int.Parse(inputline[0]);
            var number = inputline[1].Reverse().ToArray();
            BigInteger result = 0;


            for (int i = 0; i < number.Length; i++)
            {
                var currentNum = int.Parse(number[i].ToString());
                result += currentNum * BigInteger.Pow(baseOfTheNumber, i);
            }

            Console.WriteLine(result);
        }
    }
}
