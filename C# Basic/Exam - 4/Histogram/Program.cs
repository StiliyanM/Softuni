using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            double countp1 = 0;
            double countp2 = 0;
            double countp3 = 0;
            double countp4 = 0;
            double countp5 = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num < 200)
                    countp1++;
                else if (num >= 200 && num < 400)
                    countp2++;
                else if (num >= 400 && num < 600)
                    countp3++;
                else if (num >= 600 && num < 800)
                    countp4++;
                else if (num >= 800)
                    countp5++;
            }


            double p1 = countp1 / n * 100;
            double p2 = countp2 / n * 100;
            double p3 = countp3 / n * 100;
            double p4 = countp4 / n * 100;
            double p5 = countp5 / n * 100;

            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
            Console.WriteLine("{0:f2}%", p4);
            Console.WriteLine("{0:f2}%", p5);

        }
    }
}
