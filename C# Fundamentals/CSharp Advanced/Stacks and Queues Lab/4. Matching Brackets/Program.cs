using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var expr = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < expr.Length; i++)
            {
                if(expr[i] == '(')
                {
                    stack.Push(i);
                }
                if(expr[i] == ')')
                {
                    var startIndex = stack.Pop();
                    Console.WriteLine(expr.Substring(startIndex,i - startIndex  + 1));
                }
            }
        }
    }
}
