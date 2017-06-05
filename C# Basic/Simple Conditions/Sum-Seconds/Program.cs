using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            int result = num1 + num2 + num3;
            int minutes = result / 60;
            if (result < 60 && result >=10)
                Console.WriteLine("0:" + result);
            else if (result > 60 && result < 120 && Math.Abs(60 - result) >= 10)
                Console.WriteLine("1:{0}", Math.Abs(60 - result));
            else if (result > 120 && result < 180 && Math.Abs(120 - result) >= 10)
                Console.WriteLine("2:{0}", Math.Abs(120 - result));
            else
                Console.WriteLine("{0}:0{1}", minutes, Math.Abs(minutes * 60 - result));
        }
    }
}
