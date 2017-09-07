using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();
            string shorter = "";
            string longer = "";

            StringBuilder sb = new StringBuilder();


            if (str1.Length >= str2.Length)
            {
                longer = new string(str1.Reverse().ToArray());
                shorter = new string(str2.Reverse().ToArray());
            }
            else if (str2.Length > str1.Length)
            {
                longer = new string(str2.Reverse().ToArray());
                shorter = new string(str1.Reverse().ToArray());
            }

            double sum = 0;
            int bonus = 0;
            int isBonusEver0 = 0;
            for (int i = 0; i < shorter.Length; i++)
            {
                sum = char.GetNumericValue(shorter[i]) + char.GetNumericValue(longer[i]) + bonus;

                sb.Append(sum % 10);
                if (sum > 9)
                    bonus = 1;
                else
                {
                    bonus = 0;
                    isBonusEver0 = 1;
                }
            }

            for (int i = shorter.Length; i < longer.Length; i++)
            {
                double lastDigits = char.GetNumericValue(longer[i]) + bonus;
                sb.Append(lastDigits % 10);
                if (lastDigits > 9)
                    bonus = 1;
                else
                {
                    bonus = 0;
                }
            }

            if(isBonusEver0 == 0)
            {
                sb.Append(1);
            }
            Console.WriteLine(string.Join("",sb.ToString().Reverse().ToArray()));
        }
    }
}

