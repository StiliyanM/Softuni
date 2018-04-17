using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int br1 = 0;
            int br2 = 0;
            int br3 = 0;
            int br4 = 0;
            int br5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    br1++;
                }
                if (num >= 200 && num < 400)
                {
                    br2++;
                }
                if (num >= 400 && num < 600)
                {
                    br3++;
                }
                if (num >= 600 && num < 800)
                {
                    br4++;
                }
                if (num >= 800)
                {
                    br5++;
                }
            }
            double p1 = (br1 /(double) n) * 100;
            double p2 = (br2 / (double)n) * 100;
            double p3 = (br3 / (double)n) * 100;
            double p4 = (br4 / (double)n) * 100;
            double p5 = (br5 / (double)n) * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
