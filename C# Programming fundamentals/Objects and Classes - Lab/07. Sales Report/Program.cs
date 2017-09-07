using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Program
    {
        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
        }



        static void Main(string[] args)
        {
            var salesByTown = new SortedDictionary<string, decimal>();


            int n = int.Parse(Console.ReadLine());

            Sale[] sales = new Sale[n];

            for (int i = 0; i < n; i++)
            {
                Sale sale = ReadSale();

                sales[i] = sale;
            }

            foreach (var s in sales)
            {
                string town = s.Town;
                decimal sale = s.Price * s.Quantity;

                if(!salesByTown.ContainsKey(town))
                {
                    salesByTown[town] = 0; 
                }

                salesByTown[town] += sale;
            }

            foreach (var s in salesByTown)
            {
                string town = s.Key;
                decimal sale = s.Value;

                Console.WriteLine($"{town} -> {sale:f2}");
            }
        }

        private static Sale ReadSale()
        {
 
                var inputLine = Console.ReadLine().Split().ToArray();
             
                Sale sale = new Sale();
                sale.Town = inputLine[0];
                sale.Product = inputLine[1];
                sale.Price = decimal.Parse(inputLine[2]);
                sale.Quantity = decimal.Parse(inputLine[3]);            

            return sale;

        }
    }
}
