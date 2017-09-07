using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Personal_Exception
{
    class Program
    {
        class MyExceptionClass : Exception
        {
            public MyExceptionClass() : base("My first exception is awesome!!!")
            {

            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                try
                {
                    if (number < 0)
                    {
                        throw new MyExceptionClass();
                    }
                    Console.WriteLine(number);
                }
                catch (MyExceptionClass mec)
                {
                    Console.WriteLine(mec.Message);
                    return;
                }

            }

        }
    }
}
