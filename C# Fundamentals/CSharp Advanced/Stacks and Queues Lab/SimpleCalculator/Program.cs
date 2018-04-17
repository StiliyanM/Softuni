using System;
using System.Collections.Generic;
using System.Linq;
namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = Console.ReadLine().Split();

            var stack = new Stack<string>(values.Reverse());

            while (stack.Count > 1)
            {
                var first = int.Parse(stack.Pop());
                var op = stack.Pop();
                var second = int.Parse(stack.Pop());

                switch (op)
                {
                    case "+": stack.Push((first + second).ToString()); break;
                    case "-": stack.Push((first - second).ToString()); break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
