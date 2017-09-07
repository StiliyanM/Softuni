using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split(" \t".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;
            foreach (var @string in strings)
            {
                var firstLetter = @string.First();
                var secondLetter = @string.Last();
                var stringNumber = new string(@string.Where(x => char.IsDigit(x)).ToArray());
                double number = double.Parse(stringNumber);

                if (char.IsUpper(firstLetter))
                {
                    number /= firstLetter - 64;
                }
                else
                {
                    number *= firstLetter - 96;
                }

                if (char.IsUpper(secondLetter))
                {
                    number -= secondLetter - 64;
                }
                else
                {
                    number += secondLetter - 96;
                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
