using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            var a = 0.0;
            var b = 0.0;
            double r = 0.0;
            double h = 0.0;
            if (figure == "square")
            {
                a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Pow(a,2));
            }
            else if (figure == "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            else if (figure == "circle")
            {
                r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI * Math.Pow(r,2));

            }
            else if (figure == "triangle")
            {
                a = double.Parse(Console.ReadLine());
                h = double.Parse(Console.ReadLine());
                Console.WriteLine(a * h / 2);
            }
        }
    }
}
