using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananasPrice = decimal.Parse(Console.ReadLine());
            var eggsPrice = decimal.Parse(Console.ReadLine());
            var berriesPriceForKilo = decimal.Parse(Console.ReadLine());

            var sets = (int)Math.Ceiling(guests / 6d);

            decimal moneyNeeded = sets * (2 * bananasPrice + 4 * eggsPrice + berriesPriceForKilo / 5);

            var diff = cash - moneyNeeded;

            if(diff >= 0)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {Math.Abs(diff):f2}lv more.");
            }
        }
    }
}
