using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntevalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            int smaller;
            int bigger;
            if(a > b)
            {
                smaller = b;
                bigger = a;
            }
            else
            {
                smaller = a;
                bigger = b;
            }
            for (int i = smaller; i <= bigger; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
