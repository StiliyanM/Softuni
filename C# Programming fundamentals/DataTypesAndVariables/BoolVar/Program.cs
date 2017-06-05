using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolVar
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            bool boolean = Convert.ToBoolean(str);

            if(boolean == true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
