using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var floorWidth = double.Parse(Console.ReadLine());
            var floorLength = double.Parse(Console.ReadLine());
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var tilePrice = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());

            double area = floorLength * floorWidth;

            double tilesNeeded = Math.Ceiling(area / (a * h / 2)) + 5;
            double moneyNeeded = tilePrice * tilesNeeded + price;

            double diff = money - moneyNeeded;
            if(diff < 0)
                Console.WriteLine($"You'll need {Math.Abs(diff):f2} lv more.");
            else
                Console.WriteLine($"{diff:f2} lv left.");
        }
    }
}
