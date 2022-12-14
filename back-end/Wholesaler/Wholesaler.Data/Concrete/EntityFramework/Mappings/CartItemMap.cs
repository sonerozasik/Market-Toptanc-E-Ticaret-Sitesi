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
    public class CartItemMap : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Quantity).IsRequired();
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiededDate).IsRequired();
            builder.Property(c => c.isActive).IsRequired();
            builder.Property(c => c.isDeleted).IsRequired();
            builder.HasOne<Product>(c => c.Product).WithMany(p => p.CartItems).HasForeignKey(c => c.ProductId);
            builder.HasOne<ShoppingCart>(c => c.ShoppingCart).WithMany(s => s.CartItems).HasForeignKey(c => c.ShoppingCartId);
            builder.ToTable("CartItems");
        }
    }
}
