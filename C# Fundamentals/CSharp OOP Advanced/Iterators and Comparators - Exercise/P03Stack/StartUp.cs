using System;
using System.Linq;

namespace P03Stack
{
    class StartUp
    {
        static void Main()
        {
            string input;

            var stack = new CustomStack<int>();

            while ((input = Console.ReadLine()) != "END")
            {
                var arguments = input.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var command = arguments.First();

                var elements = arguments
                    .Skip(1)
                    .Select(int.Parse)
                    .ToArray();

                if(command == "Push")
                {
                    foreach (var item in elements)
                    {
                        stack.Push(item);
                    }
                }
                else if(command == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
