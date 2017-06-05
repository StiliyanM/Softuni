using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            long price = 0;
            if  (num1 <= sbyte.MaxValue)
            {
                price = num1 * 4 + num2 * 10;
            }
            else
            {
                if(num1 <= int.MaxValue)
                price = num2 * 4 + (long)num1 * 10;
            }

            Console.WriteLine(price);
                
        }
    }
}
