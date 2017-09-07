using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {

            var namesPricesQuantities = new Dictionary<string, Dictionary<double, int>>();

            while (true)
            {
                var tokens = Console.ReadLine().Split().ToArray();

                if(tokens[0] == "stocked")
                {
                    double totalPrice = 0;

                    foreach (var n in namesPricesQuantities)
                    {

                        var name1 = n.Key;
                        var pricesQuantities = n.Value;
                        double p = 0;
                        int q = 0;
                        double currentPrice = 0;
                        foreach (var item in pricesQuantities)
                        {
                             p = item.Key;
                             q += item.Value;
                        }
                        currentPrice = p * q;
                        totalPrice += currentPrice;
                        Console.WriteLine($"{name1}: ${p:F2} * {q} = ${currentPrice:F2}");
                    }
                    Console.WriteLine("------------------------------");
                    Console.WriteLine($"Grand Total: ${totalPrice:F2}");
                    break;
                }

                string name = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                if(!namesPricesQuantities.ContainsKey(name))
                {
                    namesPricesQuantities[name] = new Dictionary<double, int>();
                }
                if(!namesPricesQuantities[name].ContainsKey(price))
                {
                     namesPricesQuantities[name][price] = quantity;
                }
                else if(namesPricesQuantities[name].ContainsKey(price))
                {
                    namesPricesQuantities[name][price] += quantity;
                }
            }
        }
    }
}
