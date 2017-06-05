using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());

            int Acount = 0;
            int Bcount = 0;
            int Vcount = 0;
            int Gcount = 0;

            for (int i = 0; i < fans; i++)
            {
                var sector = Console.ReadLine();

                if (sector == "A")
                    Acount++;
                else if (sector == "B")
                    Bcount++;
                else if (sector == "V")
                    Vcount++;
                else if (sector == "G")
                    Gcount++;

            }
            double A = (double)Acount / fans * 100;
            double B = (double)Bcount / fans * 100;
            double V = (double)Vcount / fans * 100;
            double G = (double)Gcount / fans * 100;
            double all = (double)fans / capacity * 100;

            Console.WriteLine($"{A:f2}%");
            Console.WriteLine($"{B:f2}%");
            Console.WriteLine($"{V:f2}%");
            Console.WriteLine($"{G:f2}%");
            Console.WriteLine($"{all:f2}%");


        }
    }
}
