using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var size = double.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            string sizeName = string.Empty;
            string orientation = string.Empty;

            if(size < 1000)
            {
                sizeName = "B";
            }
            else if(size < 1000000)
            {
                size /= 1000;
                sizeName = "KB";
            }
            else
            {
                size /= 1000000;
                sizeName = "MB";
            }

            if(width > height)
            {
                orientation = "landscape";
            }
            else if (width == height)
            {
                orientation = "square";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }
            Console.WriteLine($"Name: DSC_{number:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hours:D2}:{minutes:D2}");
            Console.WriteLine($"Size: {size}{sizeName}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");





        }
    }
}
