using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                int length = number.ToString().Length;
                int offset = 0;
                int digit = 0;
                int letterIndex = 0;
                int lettercode = 0;
                if (length == 1)
                    digit = number;
                else if (length == 2)
                    digit = number % 10;
                else if (length == 3)
                    digit = number % 10 % (number % 100);
                else if (length == 4)
                    digit = number % 10 % (number % 100 % (number % 1000));

                offset = (digit - 2) * 3;

                if (digit == 9 || digit == 8)
                    offset += 1;

                letterIndex = offset + length - 1;
                lettercode = 97 + letterIndex;
                if (digit == 0)
                    lettercode = 32;
                    char character = (char)lettercode;
                Console.Write($"{character}");
            }
        }
    }
}
