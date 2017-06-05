using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var result = 0;
            do
            {
                result += num % 10;
                num /= 10;
            } while (num > 0);
            Console.WriteLine(result);
        }

    }
}
