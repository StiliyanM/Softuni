namespace WebServer.ByTheCakeApplication.Services
{
    using System.Collections.Generic;
    using Data;
    using Data.Models;
    using ViewModels.Products;
    using System.Linq;

    public class ProductService : IProductService
    {
        public void Create(string name, decimal price, string PictureUrl)
        {
            using (var db = new ByTheCakeDbContext())
            {
                var product = new Product
                {
                    Name = name,
                    Price = price,
                    ImageUrl = PictureUrl
                };

                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public IEnumerable<ProductListingViewModel> All(string searchTerm = null)
        {
            using (var db = new ByTheCakeDbContext())
            {
                var query = db.Products.AsQueryable();

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query = query
                        .Where(p => p.Name.ToLower().Contains(searchTerm.ToLower()));
                }

                return query
                    .Select(e => new ProductListingViewModel
                    {
                        Id = e.Id,
                        Name = e.Name,
                        Price = e.Price
                    }).ToList();
            }
        }

        public IEnumerable<ProductInCartViewModel> ProductsInCart(IEnumerable<int> ids)
        {
            using (var db = new ByTheCakeDbContext())
            {
                return db.Products
                    .Where(p => ids.Contains(p.Id))
                    .Select(e => new ProductInCartViewModel
                    {
                        Name = e.Name,
                        Price = e.Price
                    }).ToList();
            }
        }

        public ProductDetailsViewModel Find(int id)
        {
            using (var db = new ByTheCakeDbContext())
            {
                var product = db.Products.FirstOrDefault(p => p.Id == id);

                return new ProductDetailsViewModel
                {
                    Name = product.Name,
                    ImageUrl = product.ImageUrl,
                    Price = product.Price
                };
            }
        }

        public bool Exists(int id)
        {
            using (var db = new ByTheCakeDbContext())
            {
                return db.Products.Any(p => p.Id == id);
            }
        }
    }
}
