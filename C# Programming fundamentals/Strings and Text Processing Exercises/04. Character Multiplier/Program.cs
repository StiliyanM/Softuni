using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var str1 = input[0];
            var str2 = input[1];

            int minLength = Math.Min(str1.Length, str2.Length);
            int result = 0;
            for (int i = 0; i < minLength; i++)
            {
                result += str1[i] * str2[i];
            }

            if(str1.Length > str2.Length)
            for (int i = minLength; i < str1.Length; i++)
            {
                    result += str1[i];
            }
            else if (str1.Length < str2.Length)
                for (int i = minLength; i < str2.Length; i++)
                {
                    result += str2[i];
                }

            Console.WriteLine(result);
        }
    }
}
