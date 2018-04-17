using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());

            double jelevCnt = 0;
            double royalCnt = 0;
            double roliCnt = 0;
            double trofonCnt = 0;
            double sinoCnt = 0;
            double othersCnt = 0;



            for (int i = 0; i < classes; i++)
            {
                var name = Console.ReadLine().ToLower();

                switch (name)
                {
                    case "jelev":
                          jelevCnt++;
                          break;
                    case "royal":
                        royalCnt++;
                        break;
                    case "roli":
                        roliCnt++;
                        break;
                    case "trofon":
                        trofonCnt++;
                        break;
                    case "sino":
                        sinoCnt++;
                        break;
                    default:
                        othersCnt++;
                        break;
                }
            }

            double MoneyforClass = budget / classes;

            Console.WriteLine( $"Jelev salary: {jelevCnt * MoneyforClass:f2} lv");
            Console.WriteLine($"RoYaL salary: {royalCnt * MoneyforClass:f2} lv");
            Console.WriteLine($"Roli salary: {roliCnt * MoneyforClass:f2} lv");
            Console.WriteLine($"Trofon salary: {trofonCnt * MoneyforClass:f2} lv");
            Console.WriteLine($"Sino salary: {sinoCnt * MoneyforClass:f2} lv");
            Console.WriteLine($"Others salary: {othersCnt * MoneyforClass:f2} lv");


        }
    }
}
