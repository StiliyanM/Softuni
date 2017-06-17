using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var bytes = Console.ReadLine().Split().ToList();

            bytes.RemoveAll(x => !(x.Length == 2));

            int iterator = 0;
            bool isNumber = true;
            foreach (var item in bytes)
            {
                foreach (var i in item)
                {
                    if (!char.IsDigit(i))
                        isNumber = false;
                }
                iterator++;
                if(isNumber == true)
                {
                    bytes[iterator] = bytes[iterator].Reverse().ToString();
                }
            }
            bytes.Reverse();

            foreach (var item in bytes)
            {
                Console.WriteLine(item);
            }

        }
    }
}
