using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            var special = int.Parse(Console.ReadLine());
            var control = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                for (int j = m; j > 0; j--)
                {
                    
                    {
                        for (int k = l; k > 0; k--)
                        {
                            if ((i + j + k) % 3 == 0)
                                special += 5;
                            else if (k == 5)
                                special -= 2;
                            else if (k % 2 == 0)
                                special *= 2;

                            if (special >= control)
                            {
                                Console.WriteLine($"Yes! Control number was reached! Current special number is {special}.");
                                return;
                            }
                        }
                    }
                   
                }
            }
            Console.WriteLine($"No! {special} is the last reached special number.");
        }
    }
}
