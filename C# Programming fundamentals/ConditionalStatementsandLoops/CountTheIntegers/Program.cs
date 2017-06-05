using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            try
            {
                

                while (cnt <= 100)
                {
                    var n = int.Parse(Console.ReadLine());
                    cnt++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(cnt);
                return;
            }
        }
    }
}
