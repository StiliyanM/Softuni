using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstRoomArea = double.Parse(Console.ReadLine());
            var kitchenArea = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());

            double bathroomArea = firstRoomArea / 2;
            double secondRoomArea = 1.1 * firstRoomArea;
            double thirdRoomArea = 1.1 * secondRoomArea;

            double area = 1.05 * (firstRoomArea + secondRoomArea + thirdRoomArea + kitchenArea + bathroomArea);

            double fullPrice = price * area;

            Console.WriteLine($"{fullPrice:f2}");
        }
    }
}
