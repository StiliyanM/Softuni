﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int beg = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for ( int i = beg; i <= end; i++)
            {
                Console.Write((char)i);
                Console.Write(" ");
            }
        }

    }
}
