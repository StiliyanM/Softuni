using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class WeatherInfo
    {
        public double AverageTemp { get; set; }
        public string WeatherType { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var regex =
                new Regex(@"(?<city>[A-Z]{2})(?<temp>\d+\.\d+)(?<weather>[A-Za-z]+(&|(?=\|)))");


            var cities = new Dictionary<string, WeatherInfo>();
            while (true)
            {
                var input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }
                var weatherMatch = regex.Match(input);

                if (!weatherMatch.Success)
                {
                    continue;
                }
               

                var city = weatherMatch.Groups["city"].Value;
                var temp = double.Parse(weatherMatch.Groups["temp"].Value);
                var weatherType = weatherMatch.Groups["weather"].Value;

                if(!cities.ContainsKey(city))
                {
                    cities[city] = new WeatherInfo()
                    {
                        AverageTemp = temp,
                        WeatherType = weatherType
                    };
                }

                cities[city].AverageTemp = temp;
                cities[city].WeatherType = weatherType;

            }

            foreach (var m in cities.OrderBy(x => x.Value.AverageTemp))
            {
                Console.WriteLine($"{m.Key} => {m.Value.AverageTemp:f2} => {m.Value.WeatherType}");
            }
        }
    }
}
