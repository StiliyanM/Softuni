using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int firstmax = GetMax(n1, n2);

            int max = GetMax(firstmax, n3);

            Console.WriteLine(max);
        }

        static int GetMax(int n1, int n2)
        {
            if (n1 >= n2)
                return n1;
            else
                return n2;
        }
    }
}
