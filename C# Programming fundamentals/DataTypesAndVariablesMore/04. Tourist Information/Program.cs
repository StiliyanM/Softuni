using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double valueToConvert = double.Parse(Console.ReadLine());

            string outUnit = string.Empty;
            double convertedValue = 0;

            switch (imperialUnit)
            {
                case "miles":
                    convertedValue = valueToConvert * 1.6;
                    outUnit = "kilometers";
                    break;
                case "inches":
                    convertedValue = valueToConvert * 2.54;
                    outUnit = "centimeters";
                    break;
                case "feet":
                    convertedValue = valueToConvert * 30;
                    outUnit = "centimeters";
                    break;
                case "yards":
                    convertedValue = valueToConvert * 0.91;
                    outUnit = "meters";
                    break;
                case "gallons":
                    convertedValue = valueToConvert * 3.8;
                    outUnit = "liters";
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{valueToConvert} {imperialUnit} = {convertedValue:f2} {outUnit}");
        }
    }
}
