using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var driverNames = Regex.Split(Console.ReadLine(),@"\s+");
            var zones = Regex.Split(Console.ReadLine(), @"\s+")
                .Select(double.Parse).ToArray();
            var checkPoints = Regex.Split(Console.ReadLine(), @"\s+").
            Select(int.Parse).ToArray();

            foreach (var driver in driverNames)
            {
                double fuel = driver[0];
                Console.Write(driver + " - ");
                for (int i = 0; i < zones.Length; i++)
                {
                    if(checkPoints.Contains(i))
                    {
                        fuel += zones[i];
                    }
                    else
                    {
                        fuel -= zones[i];
                    }

                    if(fuel <= 0)
                    {
                        Console.WriteLine($"reached {i}");
                        break;
                    }
                }
                if (fuel > 0)
                    Console.WriteLine($"fuel left {fuel:f2}");
            }
        }
    }
}
