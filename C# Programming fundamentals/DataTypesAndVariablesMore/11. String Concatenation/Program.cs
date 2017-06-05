using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string EvenOrOdd = Console.ReadLine().ToLower();
            int n = int.Parse(Console.ReadLine());

            string result = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string str = Console.ReadLine();
                if(EvenOrOdd == "odd")
                {
                    if(i % 2 != 0)
                    {
                        result += str + delimiter;
                    }
                }
                else
                {
                    if (i % 2 == 0)
                        result += str + delimiter;
                }
            }

            result = result.Remove(result.Length - 1);
            Console.WriteLine(result);
        }
    }
}
