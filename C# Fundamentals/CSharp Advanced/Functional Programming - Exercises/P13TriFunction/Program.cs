using System;
using System.Linq;

namespace P13TriFunction
{
    class Program
    {
       static Func<string, int, bool> SumOfCharactersEqualOrLargerThan =
            (str, count) => str.ToCharArray().Sum(e => e) >= count;

        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split();

           FilterAndPrintFirstName(SumOfCharactersEqualOrLargerThan,names,number);
            
        }

        private static void FilterAndPrintFirstName(Func<string, int, bool> sumOfCharactersEqualOrLargerThan, string[] names, int number)
        {
           var firstName = names.FirstOrDefault(n => SumOfCharactersEqualOrLargerThan(n, number));

            if(firstName != null)
            Console.WriteLine(firstName);
        }
    }
}
