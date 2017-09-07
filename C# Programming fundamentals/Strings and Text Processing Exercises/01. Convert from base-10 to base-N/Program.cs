using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputline = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            BigInteger baseToConvertTo = inputline[0];
            BigInteger numberToConvert = inputline[1];

            StringBuilder sb = new StringBuilder();

            BigInteger divisionResult = 0;
            BigInteger divisionRemainder = 0;

            while (true)
            {
                divisionResult = numberToConvert / baseToConvertTo;
                divisionRemainder = numberToConvert % baseToConvertTo;
                sb.Append(divisionRemainder);

                if (divisionResult == 0)
                    break;
                else
                    numberToConvert = divisionResult;
            }

            Console.WriteLine(string.Join("",sb.ToString().Reverse().ToArray()));

        }
    }
}
