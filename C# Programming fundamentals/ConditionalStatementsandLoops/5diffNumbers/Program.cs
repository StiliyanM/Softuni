using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5diffNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if(b - a < 5)
            {
                Console.WriteLine("No");
                return;
            }

            int n1, n2, n3, n4, n5;

            n1 = a;
            n2 = a + 1;
            n3 = n2 + 1;
            n4 = n3 + 1;
            n5 = n4 + 1;

            for ( n1 = a; n1 < n2; n1++)
            {
                for (n2 = n1 + 1; n2 < n3; n2++)
                {
                    for (n3 = n2 + 1; n3 < n4; n3++)
                    {
                        for (n4 = n3 + 1; n4 < n5; n4++)
                        {
                            for ( n5 = n4 + 1; n5 <= b; n5++)
                            {
                                Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                            }
                        }
                    }
                }
            }


        }
    }
}
