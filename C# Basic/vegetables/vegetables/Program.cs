using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vegetables
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegetablesPrice = double.Parse(Console.ReadLine());
            var fruitsPrice = double.Parse(Console.ReadLine());
            var vegetables = int.Parse(Console.ReadLine());
            var fruits = int.Parse(Console.ReadLine());

            double result = (vegetables * vegetablesPrice + fruits * fruitsPrice) / 1.94;
            Console.WriteLine(result);
        }
    }
}
