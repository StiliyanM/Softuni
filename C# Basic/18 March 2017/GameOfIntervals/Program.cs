using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var moves = double.Parse(Console.ReadLine());
            double points = 0;
            int cnt1 = 0;
            int cnt2 = 0;
            int cnt3 = 0;
            int cnt4 = 0;
            int cnt5 = 0;
            int cnt6 = 0;


            for (int i = 0; i < moves; i++)
            {
                var number = double.Parse(Console.ReadLine());

                if (number < 0 || number > 50)
                {
                    points /= 2;
                    cnt6++;
                }
                else if (number < 10)
                {
                    points += 0.2 * number;
                    cnt1++;
                }
                else if (number < 20)
                {
                    points += 0.3 * number;
                    cnt2++;
                }
                else if (number < 30)
                {
                    points += 0.4 * number;
                    cnt3++;
                }
                else if (number < 40)
                {
                    points += 50;
                    cnt4++;
                }
                else if (number <= 50)
                {
                    points += 100;
                    cnt5++;
                }

            }
            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {cnt1 / moves * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {cnt2 / moves * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {cnt3 / moves * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {cnt4 / moves * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {cnt5 / moves * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {cnt6 / moves * 100:f2}%");

        }
    }
}
