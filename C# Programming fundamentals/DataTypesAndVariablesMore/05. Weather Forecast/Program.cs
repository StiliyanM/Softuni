using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
           
            string result = "Rainy";

            if(number.Contains("."))
            {
                Console.WriteLine(result);
                return;
            }

            long n = long.Parse(number);

                if (n <= sbyte.MaxValue && n >= sbyte.MinValue)
                    result = "Sunny";
                else if (n <= int.MaxValue && n >= int.MinValue)
                    result = "Cloudy";
                else if (n <= long.MaxValue && n >= long.MinValue)
                    result = "Windy";

                Console.WriteLine(result);
                
            }



        }
    }

