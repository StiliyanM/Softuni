﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if(counter + liters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    counter += liters;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
