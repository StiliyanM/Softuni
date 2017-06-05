using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());


            int cnt = 0;
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    cnt++;

                    if(i + j == magicNum)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicNum}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{cnt} combinations - neither equals {magicNum}");
        }
    }
}
