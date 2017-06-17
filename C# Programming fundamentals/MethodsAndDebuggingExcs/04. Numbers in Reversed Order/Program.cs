using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            string reverse = GetRevercedNum(num);

            Console.WriteLine(reverse);
        }

        static string GetRevercedNum(string num)
        {
            int length = num.Length - 1;
            string reverse = string.Empty;
            while (length >= 0)
            {
                reverse += num[length];
                length--;
            }

            return reverse;
        }
    }
}
