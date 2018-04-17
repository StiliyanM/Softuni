using System;
using System.Linq;

namespace P04Froggy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            var lake = new Lake(elements);

            Console.WriteLine(string.Join(", ",lake));
        }
    }
}
