using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {

            var countryCityPopulation = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var input = Console.ReadLine().Split('|').ToArray();

                if(input[0] == "report")
                {
                    var orderedCountries = countryCityPopulation.OrderByDescending(x => x.Value.Values.Sum());

                    foreach (var orderedCountry in orderedCountries)
                    {
                        var orderedCities = orderedCountry.Value.OrderByDescending(y => y.Value);
                        Console.WriteLine($"{orderedCountry.Key} (total population: {orderedCountry.Value.Values.Sum()})");

                        
                        foreach (var oCity in orderedCities)
                        {
                            Console.WriteLine($"=>{oCity.Key}: {oCity.Value}");
                        }
                    }
                    break;
                }
                string city = input[0];
                string country = input[1];
                long population = long.Parse(input[2]);

                if(!countryCityPopulation.ContainsKey(country))
                {
                    countryCityPopulation[country] = new Dictionary<string, long>();
                }
                if(!countryCityPopulation[country].ContainsKey(country))
                {
                    countryCityPopulation[country].Add(city, population);
                }
                else
                {
                    countryCityPopulation[country][city] += population;
                }

            }

        }
    }
}
