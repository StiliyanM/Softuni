using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var whiskyPrice = double.Parse(Console.ReadLine());
            var beer = double.Parse(Console.ReadLine());
            var wine = double.Parse(Console.ReadLine());
            var rakia = double.Parse(Console.ReadLine());
            var whisky = double.Parse(Console.ReadLine());

            double rakiaPrice = (whiskyPrice) / 2;
            double winePrice = rakiaPrice * 0.6;
            double beerPrice = 0.2 * rakiaPrice;

            double moneyNeeded = whisky * whiskyPrice + beer * beerPrice + wine * winePrice + rakia * rakiaPrice;
            Console.WriteLine($"{moneyNeeded:f2}");


        }
    }
}
