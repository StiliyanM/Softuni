using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombinaton
{
    class Program
    {
        static void Main(string[] args)
        {
            var beg = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());

            int cnt = 0;
            for (int i = beg; i <= end; i++)
            {
                for (int j = beg; j <= end; j++)
                {
                    Console.Write($"<{i}-{j}>");
                    cnt++;
                    if (cnt == max)
                        return;
                }
            }
        }
    }
}
