using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var BPM = int.Parse(Console.ReadLine());
            var beatsCnt = int.Parse(Console.ReadLine());

            double bars = (double)beatsCnt / 4.0;

            double barsPM = (double)BPM / 4;
            double barsPerSeconds = (int)bars / barsPM * 60;

            Console.WriteLine($"{Math.Round(bars, 1)} bars - {(int)barsPerSeconds / 60}m {(int)barsPerSeconds % 60}s");
        }
    }
}
