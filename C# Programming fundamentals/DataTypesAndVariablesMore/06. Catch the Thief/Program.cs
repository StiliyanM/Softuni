using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string id = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            long thiefID = 0;

            long temp = long.MinValue;

            for (int i = 0; i < n; i++)
            {

                
                long num = long.Parse(Console.ReadLine());

                if (id == "sbyte")
                {
                    if (num <= sbyte.MaxValue)
                    {
                        if (num > temp)
                            temp = num;
                    }
                }
                else if (id == "int")
                {
                    if (num <= int.MaxValue)
                    {
                        if (num > temp)
                            temp = num;
                    }
                }
                else if (id == "long")
                {
                    if (num <= long.MaxValue)
                    {
                        if (num > temp)
                            temp = num;
                    }
                }
                thiefID = temp;
            }
            
            Console.WriteLine(thiefID);

        }

    }
}