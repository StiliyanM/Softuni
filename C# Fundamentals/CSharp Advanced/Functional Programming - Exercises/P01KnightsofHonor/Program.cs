using System;
using System.Linq;
namespace P02KnightsofHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printElementsOnConsole = (input) =>
            input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList()
            .ForEach(e => Console.WriteLine($"Sir {e}"));

            printElementsOnConsole(Console.ReadLine());
        }
    }
}
