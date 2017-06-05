using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var N1 = int.Parse(Console.ReadLine());
            var N2 = int.Parse(Console.ReadLine());
            var op = char.Parse(Console.ReadLine());

            double result = 0.0;
            string evenOrNot = string.Empty;
            
            
            if(op == '+' || op == '-' || op == '*')
            {

                if (op == '+')
                {
                    result = N1 + N2;
                    if (result % 2 == 0)
                        evenOrNot = "even";
                    else
                        evenOrNot = "odd";
                }
                else if(op == '-')
                {
                    result = N1 - N2;
                    if (result % 2 == 0)
                        evenOrNot = "even";
                    else
                        evenOrNot = "odd";
                }
                else
                {
                    result = N1 * N2;
                    if (result % 2 == 0)
                        evenOrNot = "even";
                    else
                        evenOrNot = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", N1, op, N2, evenOrNot);
            }
            else if(op == '/')
            {
                if(N2 == 0)
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                else
                {
                    result = (double)N1 / N2;
                    Console.WriteLine("{0} / {1} = {2:f2}", N1, N2, result);
                }
            }
            else
            {
                result = N1 % N2;
                Console.WriteLine("{0} % {1} = {2}", N1, N2, result);
            }
        }
    }
}
