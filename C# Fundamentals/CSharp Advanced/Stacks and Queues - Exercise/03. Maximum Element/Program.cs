using System;
using System.Collections.Generic;

namespace _03._Maximum_Element
{
    class Program
    {
        static void Main()
        {
            var stack = new Stack<int>();

            var maxElementsStack = new Stack<int>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var args = Console.ReadLine().Split();              

                var commandNum = int.Parse(args[0]);

                switch (commandNum)
                {
                    case 1:
                        var element = int.Parse(args[1]);

                        stack.Push(element);

                        if(maxElementsStack.Count > 0)
                        {
                            var maxElement = maxElementsStack.Peek();

                            if (element > maxElement)
                            {                                
                                maxElementsStack.Push(element);
                            }
                        }
                        else
                        {
                            maxElementsStack.Push(element);
                        }

                        break;
                    case 2:
                        if(stack.Count > 0)
                        {
                            var elementToPop = stack.Pop();

                            if(maxElementsStack.Count > 0)
                            if(elementToPop == maxElementsStack.Peek())
                            {
                                maxElementsStack.Pop();
                            }
                        }
                        break;
                    case 3:
                        if(maxElementsStack.Count > 0)
                        Console.WriteLine(maxElementsStack.Peek());
                        break;
                }
            }
        }
    }
}
