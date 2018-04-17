using System;
using System.Collections.Generic;

namespace _09._Stack_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var stack = new Stack<long>();

            stack.Push(0);
            stack.Push(1);

            for (int i = 1; i < n; i++)
            {
                var n1 = stack.Pop();
                var n2 = stack.Peek();
                stack.Push(n1);
                stack.Push(n1 + n2);
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
