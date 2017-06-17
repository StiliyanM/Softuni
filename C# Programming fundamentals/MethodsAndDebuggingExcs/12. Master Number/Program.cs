using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                
                if(IsPalindrome(i) && GetSumOfDigits(i) % 7 == 0 && HasOneEvenDigit(i))
                {
                    Console.WriteLine(i);
                }

            }
        }

        private static bool HasOneEvenDigit(int number)
        {
            int num = 0;
            while(number > 0)
            {
                num = number % 10;
                if (num % 2 == 0)
                    return true;
                number = number / 10;
            }
            return false;
        }

        private static int GetSumOfDigits(int number)
        {

            int digit = 0;
            int sum = 0;
            while (number > 0)
            {
                digit = number % 10;
                sum += digit;
                number /= 10;
            }

            return sum;
        }

        static bool IsPalindrome(int n)
        {
            string number = Convert.ToString(n);

            int startNumber = 0;
            int endNumber = number.Length - 1;
           
            if (number.Length == 1)
                return true;
            else
            {
                while (startNumber - endNumber <= 1)
                {
                    char start = number[startNumber];
                    char end = number[endNumber];

                    if (start != end)
                        return false;

                    startNumber++;
                    endNumber--;
                }
                return true;
            }

        }
    }
}
