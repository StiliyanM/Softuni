using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var battles = int.Parse(Console.ReadLine());

            int cnt = 0;
            for (int i =1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write($"({i} <-> {j})");                   
                    Console.Write(" ");
                    cnt++;
                    if (battles == cnt)
                        return;
                }
            }
        }
    }
}
