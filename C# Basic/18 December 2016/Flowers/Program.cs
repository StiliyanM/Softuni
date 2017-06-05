using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var r = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var whichDay = char.Parse(Console.ReadLine());

            double hPrice = 0;
            double rPrice = 0;
            double lPrice = 0;

            double bucketPrice = 0;

            if(season == "Spring" || season == "Summer")
            {
                hPrice = 2 * h;
                rPrice = 4.1 * r;
                lPrice = 2.5 * l;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                hPrice = 3.75 * h;
                rPrice = 4.5 * r;
                lPrice = 4.15 * l;
            }
            bucketPrice += hPrice + rPrice + lPrice;

            if(whichDay == 'N')
            {
                if (l > 7 && season == "Spring")
                    bucketPrice *= 0.95;
                if (r >= 10 && season == "Winter")
                    bucketPrice *= 0.9;
                if (h + r + l > 20)
                    bucketPrice *= 0.8;
            }
            else if(whichDay == 'Y')
            {
                bucketPrice *= 1.15;
                if (l > 7 && season == "Spring")
                    bucketPrice *= 0.95;
                if (r >= 10 && season == "Winter")
                    bucketPrice *= 0.9;
                if (h + r + l > 20)
                    bucketPrice *= 0.8;
            }
            
            Console.WriteLine($"{bucketPrice + 2:f2}");
        }
    }
}
