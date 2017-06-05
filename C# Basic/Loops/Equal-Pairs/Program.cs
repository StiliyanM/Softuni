using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());

            int OldPair = n1 + n2;
            int MaxDiff = 0;
            int NewPair = 0;
            int counter = 0;
            for (int i = 0; i < n - 1; i++)
            {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());

                NewPair = num1 + num2;
                counter = Math.Abs(NewPair - OldPair);
                if (OldPair == NewPair)
                {
                    counter += 1;
                }
               else if(OldPair != NewPair)
                {
                    MaxDiff = Math.Abs(NewPair - OldPair);
                }     

            }
        }
    }
}
