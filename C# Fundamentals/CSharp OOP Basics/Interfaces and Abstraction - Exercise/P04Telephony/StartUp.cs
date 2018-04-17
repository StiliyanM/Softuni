using System;
using System.Linq;

namespace P04Telephony
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToList();
            var sites = Console.ReadLine().Split().ToList();

            var smartphone = new Smartphone(numbers,sites);

            Console.WriteLine(smartphone.Call());
            Console.WriteLine(smartphone.Browse());
        }
    }
}
