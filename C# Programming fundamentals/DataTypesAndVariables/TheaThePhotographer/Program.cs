using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            uint picturesAmount = uint.Parse(Console.ReadLine());
            uint filterTime = uint.Parse(Console.ReadLine());
            uint filterFactor = uint.Parse(Console.ReadLine());
            uint uploadTime = uint.Parse(Console.ReadLine());

            uint goodPicsCnt = (uint)Math.Ceiling((double)picturesAmount * filterFactor / 100.0);

            uint totalTime = filterTime * picturesAmount + uploadTime * goodPicsCnt;
            

            uint d = totalTime / (3600 * 24);
            uint hh = (totalTime - d * 3600 * 24) / 3600;
            uint mm = (totalTime - (d * 3600 * 24 + hh * 3600)) / 60;
            uint ss = (totalTime - (d * 3600 * 24 + hh * 3600 + mm * 60));


            Console.WriteLine($"{d:0}:{hh:00}:{mm:00}:{ss:00}");
        }
    }
}
