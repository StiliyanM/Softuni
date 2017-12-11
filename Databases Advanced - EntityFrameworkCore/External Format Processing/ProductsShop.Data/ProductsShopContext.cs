using Microsoft.EntityFrameworkCore;
using ProductsShop.Models;

namespace ProductsShop.Data
{
    public class ProductsShopContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<CategoryProduct> CategoryProducts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public ProductsShopContext(DbContextOptions options) : base(options)
        {

        }

        public ProductsShopContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfig());
            builder.ApplyConfiguration(new CategoryProductConfig());
            builder.ApplyConfiguration(new ProductConfig());
            builder.ApplyConfiguration(new UserConfig());
        }
    }
}
