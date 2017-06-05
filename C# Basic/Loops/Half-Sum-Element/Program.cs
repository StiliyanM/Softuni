using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var biggest = int.Parse(Console.ReadLine());
            int sum = biggest;
            int diff = 0;

            for(int i = 0; i < n-1; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > biggest)
                    biggest = num;
                sum += num;
            }
            Console.WriteLine(sum);
            Console.WriteLine(biggest);
            diff = Math.Abs(2 * biggest - sum);

            if(diff == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + biggest);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
