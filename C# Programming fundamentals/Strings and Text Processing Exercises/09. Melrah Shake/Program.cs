using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                try
                {
                    str = str.Remove(str.IndexOf(pattern), pattern.Length);
                    str = str.Remove(str.LastIndexOf(pattern), pattern.Length);
                    Console.WriteLine("Shaked it.");
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                    if (pattern == "")
                        pattern[1].ToString(); // just to get exception
                }
                catch (Exception)
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(str);
                    return;
                }


            }
        }
    }
}
