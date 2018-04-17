using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            int microbusCnt = 0;
            int truckCnt = 0;
            int trainCnt = 0;
            int tons = 0;

            int mTons = 0;
            int truckTons = 0;
            int trainTons = 0;

            for (int i = 0; i < count; i++)
            {
                var weight = int.Parse(Console.ReadLine());

                if(weight < 4)
                {
                    tons += weight;
                    microbusCnt += weight * 200;
                    mTons += weight;
                }
                else if(weight < 12)
                {
                    tons += weight;
                    truckCnt += weight * 175;
                    truckTons += weight;
                }
                else
                {
                    tons += weight;
                    trainCnt += weight * 120;
                    trainTons += weight;
                }
            }

            double averagePrice = (double)(microbusCnt + truckCnt + trainCnt) / tons;

            double microbus = (double)mTons / tons * 100;
            double truck = (double)truckTons / tons * 100;
            double train = (double)trainTons / tons * 100;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{microbus:f2}%");
            Console.WriteLine($"{truck:f2}%");
            Console.WriteLine($"{train:f2}%");

        }
    }
}
