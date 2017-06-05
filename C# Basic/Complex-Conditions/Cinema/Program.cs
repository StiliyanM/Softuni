using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            double tickets = r * c;
            double MoneyMade = 0.0;

            if (type == "Premiere")
                MoneyMade = tickets * 12;
            else if (type == "Normal")
                MoneyMade = tickets * 7.50;
            else if (type == "Discount")
                MoneyMade = tickets * 5;

            Console.WriteLine("{0:f2} leva", Math.Round(MoneyMade, 2));
                
        }
    }
}
