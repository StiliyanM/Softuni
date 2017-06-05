using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var beg = char.Parse(Console.ReadLine());
            var end = char.Parse(Console.ReadLine());
            var miss = char.Parse(Console.ReadLine());

            int cnt = 0;

            for (char i = beg; i <= end; i++)
            {
                for (char j = beg; j <= end; j++)
                {
                    for (char k = beg; k <= end; k++)
                    {
                        if(i != miss)
                        {
                            if(j != miss)
                            {
                                if(k != miss)
                                {
                                    Console.Write($"{i}{j}{k}");
                                    Console.Write(" ");
                                    cnt++;
                                }
                            }
                        }

                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
