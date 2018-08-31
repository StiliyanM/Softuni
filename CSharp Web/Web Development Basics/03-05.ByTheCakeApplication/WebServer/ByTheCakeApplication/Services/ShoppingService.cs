namespace WebServer.ByTheCakeApplication.Services
{
    using Data;
    using Data.Models;
    using ViewModels.Shopping;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingService : IShoppingService
    {
        public void CreateOrder(int userId, IEnumerable<int> productIds)
        {
            using (var db = new ByTheCakeDbContext())
            {
                var order = new Order
                {
                    UserId = userId,
                    CreationDate = DateTime.UtcNow,
                    Products = productIds.Select(id => new OrderProduct
                    {
                        ProductId = id
                    }).ToList()
                };

                db.Add(order);

                db.SaveChanges();
            }
        }

        public IEnumerable<OrderListingViewModel> OrdersByUser(int userId)
        {
            using (var db = new ByTheCakeDbContext())
            {
                return db.Orders
                        .Where(o => o.UserId == userId)
                        .Select(o => new OrderListingViewModel
                        {
                            Id = o.Id,
                            CreatedOn = o.CreationDate,
                            Sum = o.Products.Sum(p => p.Product.Price)
                        }).OrderByDescending(e => e.CreatedOn)
                        .ToList();
            }
        }

        public OrderDetailsViewModel GetOrderDetails(int id)
        {
            using (var db = new ByTheCakeDbContext())
            {
                return db.Orders
                        .Where(o => o.Id == id)
                        .Select(e => new OrderDetailsViewModel
                        {
                            Id = e.Id,
                            CreatedOn = e.CreationDate,
                            Products = e.Products
                        .Select(p => new ProductViewModel
                        {
                            Id = p.ProductId,
                            Name = p.Product.Name,
                            Price = p.Product.Price
                        }).ToList()
                        .ToList()
                        }).FirstOrDefault();
            }
        }
    }
}
