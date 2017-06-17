using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ').ToList();

            int sum = 0;
            foreach (var item in numbers)
            {
                string number = new string(item.ToCharArray().Reverse().ToArray());
                
                sum += int.Parse(number);
            }
            Console.WriteLine(sum);
        }
    }
}
