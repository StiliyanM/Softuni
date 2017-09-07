using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyAndBilliard
{
    class Program
    {
        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> ShopList { get; set; }
            public decimal Bill { get; set; }
        }
        static void Main(string[] args)
        {
            var EntitiesPrices = new Dictionary<string, decimal>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split('-').ToArray();
                string entity = tokens[0];
                decimal price = decimal.Parse(tokens[1]);

                if (!EntitiesPrices.ContainsKey(entity))
                    EntitiesPrices[entity] = 0;

                EntitiesPrices[entity] = price;
            }

            var customers = new List<Customer>();

            decimal totalBill = 0;


            while (true)
            {
                var input = Console.ReadLine();
                if (input != "end of clients")
                {
                    customers.Add(AddCustomer((EntitiesPrices), input));
                }
                else
                    foreach (var c in customers.OrderBy(x => x.Name))
                    {

                        Console.WriteLine(c.Name);

                        var shopList = c.ShopList;

                        if(shopList.ContainsKey())

                        foreach (var item in shopList)
                        {

                            Console.WriteLine($"-- {item.Key} - {item.Value}");
                        }
                        if (c.Bill != 0)
                        {
                            c.Bill = Math.Round(c.Bill, 2);
                            Console.WriteLine($"Bill: {c.Bill:f2}");
                            
                        }
                        totalBill += c.Bill;
                    }
                if(input == "end of clients")
                {
                    Console.WriteLine($"Total bill: {totalBill:f2}");
                    return;
                }
            }

        }

        private static Customer AddCustomer(Dictionary<string, decimal> EntitiesPrices, string input)
        {
            var tokens = input.Split(',').ToArray();

            int quantity = int.Parse(tokens[1]);

            var customerOrders = tokens[0].Split('-').ToArray();
            string name = customerOrders[0];
            string productName = customerOrders[1];

            var newCustomer = new Customer();

            if (EntitiesPrices.ContainsKey(productName))
            {
                var shopList = newCustomer.ShopList = new Dictionary<string, int>();

                newCustomer.Name = name;

                if (!shopList.ContainsKey(productName))
                    shopList[productName] = 0;

                shopList[productName] = quantity;
                newCustomer.Bill = EntitiesPrices[productName] * quantity;
                newCustomer.ShopList = shopList;
            }


            return newCustomer;
        }
    }
}
