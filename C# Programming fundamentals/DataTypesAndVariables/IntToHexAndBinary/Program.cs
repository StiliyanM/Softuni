using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            Console.WriteLine(Convert.ToString(num,16).ToUpper());
            Console.WriteLine(Convert.ToString(num,2));
        }
    }
}
