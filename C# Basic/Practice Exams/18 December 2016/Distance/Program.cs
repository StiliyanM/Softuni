using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed = int.Parse(Console.ReadLine());
            var firstTime = int.Parse(Console.ReadLine());
            var secondTime = int.Parse(Console.ReadLine());
            var thirdTime = int.Parse(Console.ReadLine());

          //  Console.WriteLine((double)thirdTime / 60);

            double distance = (double)firstTime * speed / 60 + secondTime *  1.1 *speed / 60 + speed * 1.1 * 0.95 * thirdTime / 60;

            Console.WriteLine($"{distance:f2}");
        }
    }
}
