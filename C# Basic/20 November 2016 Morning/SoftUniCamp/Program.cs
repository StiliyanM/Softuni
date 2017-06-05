using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = int.Parse(Console.ReadLine());

            int carCnt = 0;
            int microbusCnt = 0;
            int smallBusCnt = 0;
            int busCnt = 0;
            int trainCnt = 0;

            int people = 0;
            for (int i = 0; i < groups; i++)
            {
                var groupsCount = int.Parse(Console.ReadLine());

                if (groupsCount <= 5)
                {
                    carCnt += groupsCount;
                    people += groupsCount;
                }
                else if (groupsCount < 13)
                {
                    microbusCnt += groupsCount;
                    people += groupsCount;
                }
                else if (groupsCount < 26)
                {
                    smallBusCnt += groupsCount;
                    people += groupsCount;
                }
                else if (groupsCount < 41)
                {
                    busCnt += groupsCount;
                    people += groupsCount;
                }
                else
                {
                    trainCnt += groupsCount;
                    people += groupsCount;
                }
            }

            Console.WriteLine($"{(double)carCnt / people * 100:f2}%");
            Console.WriteLine($"{(double)microbusCnt / people * 100:f2}%");
            Console.WriteLine($"{(double)smallBusCnt / people * 100:f2}%");
            Console.WriteLine($"{(double)busCnt / people * 100:f2}%");
            Console.WriteLine($"{(double)trainCnt / people * 100:f2}%");


        }
    }
    }

