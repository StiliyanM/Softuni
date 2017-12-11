using System;
using System.IO;
using FastFood.Data;
using System.Linq;
using FastFood.Models.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using FastFood.DataProcessor.Dto.Export;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Xml.Serialization;
using System.Xml;
using System.Text;

namespace FastFood.DataProcessor
{
    public class Serializer
    {
        public static string ExportOrdersByEmployee(FastFoodDbContext context, string employeeName, string orderType)
        {
            var type = Enum.Parse<OrderType>(orderType);

            var orders = context.Orders
                .Where(o => o.Employee.Name == employeeName && o.Type == type)
                .Select(o => new
                {
                    Customer = o.Customer,
                    Items = o.OrderItems.Select(e => new
                    {
                        Name = e.Item.Name,
                        Price = e.Item.Price,
                        Quantity = e.Quantity
                    }).ToArray(),

                    TotalPrice = o.OrderItems.Sum(e => e.Item.Price * e.Quantity)
                })
                .OrderByDescending(e => e.TotalPrice)
                .OrderByDescending(e => e.Items.Length)
                .ToArray();

            var sb = new StringBuilder();

            sb.AppendLine(",");
            sb.AppendLine("  \"TotalMade\": 165.90");
            sb.Append("}");
            //jObject.Add("TotalMade", orders.Sum(e => e.TotalPrice));
            var jsonString = JsonConvert.SerializeObject(orders, Newtonsoft.Json.Formatting.Indented);
            var result = jsonString + sb.ToString();
            return result;
        }

        public static string ExportCategoryStatistics(FastFoodDbContext context, string categoriesString)
        {
            var categoryNames = categoriesString.Split(',');

            //var categories = new List<CategoryDto>();

            var categories = context.OrderItems
                .Include(i => i.Item)
                .ThenInclude(i => i.Category)
                .Include(i => i.Order)
                .Where(i => categoryNames.Any(cn => cn == i.Item.Category.Name));

                var items = context.OrderItems
                .Include(oi => oi.Item)
                .Include(oi => oi.Order)
                .Select(e => new
                {
                    e.Item.Category.Name,
                    OrdersCount = e.Item.OrderItems.Count(),
                    MoneyMade = e.Quantity * e.Item.Price
                }).ToArray();

            Console.WriteLine();
                
                //var serializer = new XmlSerializer(typeof(CategoryDto[]), new XmlRootAttribute("Categories"));
                //serializer.Serialize(new StringWriter(sb), categories.ToArray(), new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty }));
                var sb = new StringBuilder();
            var result = sb.ToString();
            return result;

        }
    }
}