using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Entities.Concrete;

namespace Wholesaler.Data.Concrete.EntityFramework.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.ProductName).HasMaxLength(100);
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Thumbnail).IsRequired();
            builder.Property(p => p.Thumbnail).HasMaxLength(250);

            builder.HasOne<Category>(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
            builder.HasOne<WholesalerUser>(p => p.WholesalerUser).WithMany(w => w.Products).HasForeignKey(p => p.WholesalerUserId);
            builder.HasOne<Stock>(p => p.Stock).WithOne(s => s.Product).HasForeignKey<Product>(s => s.StockId);

            builder.Property(p => p.CreatedByName).IsRequired();
            builder.Property(p => p.CreatedByName).HasMaxLength(50);
            builder.Property(p => p.ModifiedByName).IsRequired();
            builder.Property(p => p.ModifiedByName).HasMaxLength(50);
            builder.Property(p => p.CreatedDate).IsRequired();
            builder.Property(p => p.ModifiededDate).IsRequired();
            builder.Property(p => p.isActive).IsRequired();
            builder.Property(p => p.isDeleted).IsRequired();
            builder.ToTable("Products");
        }
    }
}
