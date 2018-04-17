using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = int.Parse(Console.ReadLine());
            var z = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var cactus = int.Parse(Console.ReadLine());
            var giftPrice = double.Parse(Console.ReadLine());

            double money = m * 3.25 + z * 4 + roses * 3.5 + cactus * 8;
            money *= 0.95;

            double diff = money - giftPrice;
            if(diff >= 0)
                Console.WriteLine($"She is left with {Math.Floor(diff)} leva.");
            else
                Console.WriteLine($"She will have to borrow {Math.Ceiling(Math.Abs(diff))} leva.");
        }
    }
}
