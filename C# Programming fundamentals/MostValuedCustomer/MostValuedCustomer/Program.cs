using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostValuedCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Dictionary<string, decimal>();
            var customers = new Dictionary<string, List<string>>();

            var shopInput = Console.ReadLine();

            while (shopInput != "Shop is open")
            {
                var tokens = shopInput.Split();
                var productName = tokens[0];
                var productPrice = decimal.Parse(tokens[1]);

                if(!shop.ContainsKey(productName))
                {
                    shop[productName] = productPrice;
                }

                shopInput = Console.ReadLine();
            }

            while (true)
            {
                var input = Console.ReadLine().Split(':');

                if(input[0] == "Discount")
                {
                    DiscountPrices(shop);
                    continue;
                }

                if(input[0] == "Print")
                {
                    break;
                }
                var customerName = input.First();
                var products = input.Last().Split(", ".ToCharArray(), StringSplitOptions.None);

                if (!customers.ContainsKey(customerName))
                {
                    customers[customerName] = new List<string>();
                }

                foreach (var product in products)
                {
                    if(!shop.ContainsKey(product))
                    {
                        continue;
                    }

                    customers[customerName].Add(product);
                }
            }

            var CustomersByMoneyGiven = new Dictionary<string, decimal>();

            foreach (var c in customers)
            {
                if(!CustomersByMoneyGiven.ContainsKey(c.Key))
                {
                    CustomersByMoneyGiven[c.Key] = 0;
                }
                var products = c.Value;
                foreach (var p in products)
                {
                    CustomersByMoneyGiven[c.Key] += shop[p];
                }
            }

            var customerToPrintDict = CustomersByMoneyGiven.OrderByDescending(x => x.Value).
                Take(1).
                ToDictionary(k => k.Key, v => v.Value);

            var customerToPrint = "";
            var totalPrice = 0m;
            foreach (var item in customerToPrintDict)
            {
                customerToPrint = item.Key;
                totalPrice = item.Value;
            }

            foreach (var c in customers.Where(x => x.Key == customerToPrint))
            {
                Console.WriteLine($"Biggest spender: {c.Key}");
                Console.WriteLine($"^Products bought:");
                var products = c.Value;

                var printProducts = new Dictionary<string, decimal>();

                foreach (var item in products)
                {
                    if(!printProducts.ContainsKey(item))
                    {
                        printProducts[item] = shop[item];
                    }
                }
                foreach (var p in printProducts.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"^^^{p.Key}: {p.Value:f2}");
                }
            }
            Console.WriteLine($"Total: {totalPrice:f2}");
        }

        private static void DiscountPrices(Dictionary<string, decimal> shop)
        {
            var discPrices = shop.OrderByDescending(x => x.Value).
                 Take(3).
                 ToDictionary(k => k.Key, v => v.Value * 0.9m);

            foreach (var dp in discPrices)
            {
                shop[dp.Key] = dp.Value;
            }
        }
    }
}
