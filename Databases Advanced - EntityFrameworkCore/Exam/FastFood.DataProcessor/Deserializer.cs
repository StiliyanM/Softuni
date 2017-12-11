using System;
using FastFood.Data;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;
using FastFood.DataProcessor.Dto.Import;
using System.Text;
using FastFood.Models;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Globalization;
using FastFood.Models.Enums;

namespace FastFood.DataProcessor
{
    public static class Deserializer
    {
        private const string FailureMessage = "Invalid data format.";
        private const string SuccessMessage = "Record {0} successfully imported.";

        public static string ImportEmployees(FastFoodDbContext context, string jsonString)
        {
            var deserializedEmployees = JsonConvert.DeserializeObject<EmployeesDto[]>(jsonString);

            var sb = new StringBuilder();

            var employees = new List<Employee>();
            var positions = new List<Position>();

            foreach (var dto in deserializedEmployees)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var position = positions.FirstOrDefault(e => e.Name == dto.Position);

                if (position == null)
                {
                    position = new Position
                    {
                        Name = dto.Position
                    };
                }

                var employee = new Employee
                {
                    Name = dto.Name,
                    Age = dto.Age,
                    Position = position
                };

                positions.Add(position);
                employees.Add(employee);
                sb.AppendLine(String.Format(SuccessMessage, dto.Name));
                
            }
            context.Positions.AddRange(positions);
            context.Employees.AddRange(employees);
            context.SaveChanges();

            var result = sb.ToString();

            return result;
        }


        public static string ImportItems(FastFoodDbContext context, string jsonString)
        {
            var deserializedItems = JsonConvert.DeserializeObject<ItemDto[]>(jsonString);

            var sb = new StringBuilder();

            var items = new List<Item>();
            var categories = new List<Category>();

            foreach (var dto in deserializedItems)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var itemExists = items.Any(i => i.Name == dto.Name);

                if (itemExists)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var category = categories.FirstOrDefault(e => e.Name == dto.Category);

                if (category == null)
                {
                    category = new Category
                    {
                        Name = dto.Category
                    };
                    categories.Add(category);
                }

                var item = new Item
                {
                    Name = dto.Name,
                    Price = dto.Price,
                    Category = category
                };

                items.Add(item);
                sb.AppendLine(String.Format(SuccessMessage, dto.Name));

            }
            context.Categories.AddRange(categories);
            context.Items.AddRange(items);
            context.SaveChanges();

            var result = sb.ToString();

            return result;
        }

        public static string ImportOrders(FastFoodDbContext context, string xmlString)
        {
            var sb = new StringBuilder();

            var serializer = new XmlSerializer(typeof(OrdersDto[]), new XmlRootAttribute("Orders"));

            var deserializedOrders = (OrdersDto[])serializer.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(xmlString)));

            var orderItems = new List<OrderItem>();

            foreach (var dto in deserializedOrders)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var employee = context.Employees.SingleOrDefault(e => e.Name == dto.Employee);

                var dateTime = DateTime.ParseExact(dto.DateTime, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                var type = Enum.Parse<OrderType>(dto.Type);

                var AllitemsExist = dto.Items.All(i => context.Items
                                                .Any(ii => ii.Name == i.Name));

                if(employee == null || !AllitemsExist)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }
                var order = new Order
                {
                    Customer = dto.Customer,
                    DateTime = dateTime,
                    Employee = employee,
                    Type = type,
                };

                foreach (var itemDto in dto.Items)
                {
                    var item = context.Items.Single(i => i.Name == itemDto.Name);
                    orderItems.Add(new OrderItem
                    {
                        Item = item,
                        Order = order,
                        Quantity = itemDto.Quantity
                    });
                }

                sb.AppendLine($"Order for {dto.Customer} on {dateTime.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)} added");
            }

            context.OrderItems.AddRange(orderItems);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new ValidationContext(obj);
            var validationResults = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);
            return isValid;
        }
    }
}