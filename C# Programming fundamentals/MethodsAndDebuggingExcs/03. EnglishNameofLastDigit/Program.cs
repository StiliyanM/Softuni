using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishNameofLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);

            string name = NameOfLastDigit(n);

            Console.WriteLine(name);
        }

        static string NameOfLastDigit(long n)
        {
            
            long number = n % 10;
            string name = string.Empty;

            number = Math.Abs(number);

            switch (number)
            {
                case 0:
                    name = "zero";
                    break;
                case 1:
                    name = "one";
                    break;
                case 2:
                    name = "two";
                    break;
                case 3:
                    name = "three";
                    break;
                case 4:
                    name = "four";
                    break;
                case 5:
                    name = "five";
                    break;
                case 6:
                    name = "six";
                    break;
                case 7:
                    name = "seven";
                    break;
                case 8:
                    name = "eight";
                    break;
                case 9:
                    name = "nine";
                    break;
                default:
                    name = "zero";
                    break;
            }

            return name;

        }
    }
}
