using System;
using System.Collections.Generic;

namespace _3._Decimal_to_Binary_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var decimalNumber = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            if(decimalNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while(decimalNumber > 0)
            {
                var remainder = decimalNumber % 2;
                decimalNumber /= 2;
                stack.Push(remainder);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
