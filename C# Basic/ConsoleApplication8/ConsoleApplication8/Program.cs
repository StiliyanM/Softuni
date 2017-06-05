using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = 0;
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = 0;
            width = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            double volume = 0;
            volume = double.Parse(Console.ReadLine());
            volume = (length + width + volume) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", V);

        }
    }
}
