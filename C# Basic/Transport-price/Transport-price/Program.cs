using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_price
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var period = Console.ReadLine().ToLower();
            double price = 0.0;
            if (n < 20 && period == "day")
                price = n * 0.79 + 0.70;
            else if (n < 20 && period == "night")
                price = n * 0.90 + 0.70;
            else if (n >= 20 && n < 100)
                price = n * 0.09;
            else if (n >= 100)
                price = n * 0.06;

            Console.WriteLine(price);
        }
    }
}
