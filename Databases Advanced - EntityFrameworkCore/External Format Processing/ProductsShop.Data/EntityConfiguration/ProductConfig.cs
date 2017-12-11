using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsShop.Models;

namespace ProductsShop.Data
{
    class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired(true);

            builder.HasOne(e => e.Seller)
                .WithMany(u => u.ProductsSold)
                .HasForeignKey(e => e.SellerId);

            builder.HasOne(e => e.Buyer)
                .WithMany(u => u.ProductsBought)
                .HasForeignKey(e => e.BuyerId);

        }
    }
}
