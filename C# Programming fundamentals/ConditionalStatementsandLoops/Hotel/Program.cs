using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nightsCnt = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;

            if(month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;

                if (nightsCnt > 7)
                    studioPrice *= 0.95;
            }
            else if(month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;

                if (nightsCnt > 14)
                    doublePrice *= 0.9;
            }
            else if(month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;

                if (nightsCnt > 14)
                    suitePrice *= 0.85;
            }

            double studio = nightsCnt * studioPrice;
            double db = nightsCnt * doublePrice;
            double suite = nightsCnt * suitePrice;

            if (month == "September" || month == "October")
            {
                if(nightsCnt > 7)
                studio = (nightsCnt - 1) * studioPrice;
            }

            Console.WriteLine($"Studio: {studio:f2} lv.");
            Console.WriteLine($"Double: {db:f2} lv.");
            Console.WriteLine($"Suite: {suite:f2} lv.");

        }
    }
}
