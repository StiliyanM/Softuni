using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (IsPalindrome(n))
                Console.WriteLine(true);
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
