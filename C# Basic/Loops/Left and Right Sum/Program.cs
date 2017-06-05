using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int left = 0;
            int right = 0;
            int diff = 0;
            for(int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                left += num;
            }
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                right += num;
            }

            diff = Math.Abs(left - right);

            if(diff == 0)
                Console.WriteLine("yes, sum = {0}", left);
            else
                Console.WriteLine("No, diff = {0}", diff);
        }
    }
}
