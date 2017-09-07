using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Morse_Code_Upgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split('|');

            double sum = 0;
            double sumOfDigits = 0;
            int sumofSequences = 0;
            StringBuilder result = new StringBuilder();

            foreach (var number in numbers)
            {
                sumOfDigits = number.Sum(x => char.GetNumericValue(x)) * 5;
                sumOfDigits += (number.Length - number.Sum(x => char.GetNumericValue(x))) * 3;
                sumofSequences = GetSumOfSequences(number);
                sum = sumOfDigits + sumofSequences;
                result.Append(Convert.ToChar((int)sum));
            }

            Console.WriteLine(result);
            
        }

        private static int GetSumOfSequences(string number)
        {
            var digitsList = number.ToList();

            var len = 1;
            var totalLen = 0;
            for (int i = 0; i < digitsList.Count - 1; i++)
            {
                if(digitsList[i] == digitsList[i + 1])
                {
                    len++;
                }
                else
                {
                    if(len > 1)
                    totalLen += len;
                    len = 1;
                }
            }
            if(len > 1)
            totalLen += len;
            return totalLen;
        }
    }
}
