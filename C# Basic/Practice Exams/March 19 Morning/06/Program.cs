using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            var beg = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());


            int cnt = 0;

            for (int i = beg; i >= end; i--)
            {
                for (int j = beg; j >= end; j--)
                {
                    cnt++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{cnt} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{cnt} combinations - neither equals {magicNumber}");

        }
    }
}
