using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Data.Abstract;
using Wholesaler.Entities.Concrete;

namespace Wholesaler.Data.Concrete.EntityFramework.Mappings
{
    public class OrderItemMap : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).ValueGeneratedOnAdd();
            builder.Property(o => o.Quantity).IsRequired();
            builder.Property(o => o.CreatedByName).IsRequired();
            builder.Property(o => o.CreatedByName).HasMaxLength(50);
            builder.Property(o => o.ModifiedByName).IsRequired();
            builder.Property(o => o.ModifiedByName).HasMaxLength(50);
            builder.Property(o => o.CreatedDate).IsRequired();
            builder.Property(o => o.ModifiededDate).IsRequired();
            builder.Property(o => o.isActive).IsRequired();
            builder.Property(o => o.isDeleted).IsRequired();
            builder.HasOne<Product>(o => o.Product).WithMany(p => p.OrderItems).HasForeignKey(o => o.ProductId);
            builder.HasOne<Order>(oi => oi.Order).WithMany(o => o.OrderItems).HasForeignKey(oi => oi.OrderId);
            builder.HasOne<Return>(o => o.Return).WithOne(r => r.OrderItem).HasForeignKey<OrderItem>(r => r.ReturnId);
            builder.ToTable("OrderItems");
        }
    }
}
