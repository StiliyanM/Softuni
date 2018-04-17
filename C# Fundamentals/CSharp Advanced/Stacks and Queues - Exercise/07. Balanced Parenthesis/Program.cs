using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Balanced_Parenthesis
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();

            var openingBrackets = @"({[".ToCharArray();
            var closingBrackets = @")}]".ToCharArray();

            var stack = new Stack<char>();

            foreach (var ch in input)
            {
                if (openingBrackets.Contains(ch))
                {
                    stack.Push(ch);
                }
                else if(closingBrackets.Contains(ch))
                {
                    if(stack.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    var lastElement = stack.Pop();

                    int openingIndex = Array.IndexOf(openingBrackets, lastElement);
                    int closingIndex = Array.IndexOf(closingBrackets, ch);

                    if(openingIndex != closingIndex)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            if(stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
