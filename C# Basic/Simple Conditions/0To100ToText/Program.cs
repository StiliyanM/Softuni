using System;

namespace _0To100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            var num = int.Parse(number);
            if(num < 0 || num > 100)
            {
                Console.WriteLine("Invalid number");
                return;
            }
            if(number.Length == 3)
            {
                Console.WriteLine("one hundred");
                return;
            }

            if(number.Length == 2)
            {
                var firstNumber = char.GetNumericValue(number[0]);
                var secondNumber = char.GetNumericValue(number[1]);

                string firstPart = "";
                string secondPart = "";

                if(firstNumber >= 2)
                {
                    switch (firstNumber)
                    {
                        case 2: firstPart = "twenty"; break;
                        case 3: firstPart = "thirty"; break;
                        case 4: firstPart = "forty"; break;
                        case 5: firstPart = "fifty"; break;
                        case 6: firstPart = "sixty"; break;
                        case 7: firstPart = "seventy"; break;
                        case 8: firstPart = "eighty"; break;
                        case 9: firstPart = "ninety"; break;
                    }

                    secondPart = DigitToText((int)secondNumber);

                    if (secondPart == "zero")
                        secondPart = "";
                }
                else if(firstNumber < 2)
                {
                    switch (int.Parse(number))
                    {
                        case 10: firstPart = "ten"; break;
                        case 11: firstPart = "eleven"; break;
                        case 12: firstPart = "twelve"; break;
                        case 13: firstPart = "thirteen"; break;
                        case 14: firstPart = "fourteen"; break;
                        case 15: firstPart = "fifteen"; break;
                        case 16: firstPart = "sixteen"; break;
                        case 17: firstPart = "seventeen"; break;
                        case 18: firstPart = "eighteen"; break;
                        case 19: firstPart = "nineteen"; break;
                    }
                }

                var result = firstPart + " " + secondPart;

                Console.WriteLine(result.Trim());
            }
            else if(number.Length == 1)
            {
                Console.WriteLine(DigitToText((int)char.GetNumericValue(number[0]))); 
            }

        }

        private static string DigitToText(int number)
        {
            var num = number;

            string result = "";

            if (num == 0)
                result = "zero";
            else if (num == 1)
                result = "one";
            else if (num == 2)
                result = "two";
            else if (num == 3)
                result = "three";
            else if (num == 4)
                result = "four";
            else if (num == 5)
                result = "five";
            else if (num == 6)
                result = "six";
            else if (num == 7)
                result = "seven";
            else if (num == 8)
                result = "eight";
            else if (num == 9)
                result = "nine";

            return result;
        }
    }
}
