using System;

namespace P01ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printElementsOnConsole = (input) => 
            Console.WriteLine(string.Join("\n", input.Split(' '))); 

            printElementsOnConsole(Console.ReadLine());
        }
    }
}
