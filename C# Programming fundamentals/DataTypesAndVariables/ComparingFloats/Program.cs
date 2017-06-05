using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            bool result = true;
            double diff = Math.Abs(a - b);

            if(diff > 0.000001)
            {
                result = false;
            }

            Console.WriteLine(result);

            }
        }
    }

