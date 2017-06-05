using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cnt = 0;

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();

                if(str == "(")
                    cnt++;
                else if(str == ")")
                    cnt--;


                if (cnt > 1 || cnt < 0)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
            if(cnt == 1)
                Console.WriteLine("UNBALANCED");  
            else
                Console.WriteLine("BALANCED");
        }
    }
}
