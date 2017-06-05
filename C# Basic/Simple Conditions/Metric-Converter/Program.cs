using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var toBeConverted = double.Parse(Console.ReadLine());
            var firstMetric = Console.ReadLine().ToLower();
            var secondMetric = Console.ReadLine().ToLower();

            if (firstMetric == "mm")
                toBeConverted = toBeConverted / 1000;
            else if (firstMetric == "cm")
                toBeConverted = toBeConverted / 100;
            else if (firstMetric == "mi")
                toBeConverted = toBeConverted / 0.000621371192;
            else if (firstMetric == "in")
                toBeConverted = toBeConverted / 39.3700787;
            else if (firstMetric == "km")
                toBeConverted = toBeConverted / 0.001;
            else if (firstMetric == "ft")
                toBeConverted = toBeConverted / 3.2808399;
            else if (firstMetric == "yd")
                toBeConverted = toBeConverted / 1.0936133;

            if (secondMetric == "mm")
                toBeConverted = toBeConverted * 1000;
            else if (secondMetric == "cm")
                toBeConverted = toBeConverted * 100;
            else if (secondMetric == "mi")
                toBeConverted = toBeConverted * 0.000621371192;
            else if (secondMetric == "in")
                toBeConverted = toBeConverted * 39.3700787;
            else if (secondMetric == "km")
                toBeConverted = toBeConverted * 0.001;
            else if (secondMetric == "ft")
                toBeConverted = toBeConverted * 3.2808399;
            else if (secondMetric == "yd")
                toBeConverted = toBeConverted * 1.0936133;

            Console.WriteLine(toBeConverted + " " + secondMetric);
        }
    }
}
