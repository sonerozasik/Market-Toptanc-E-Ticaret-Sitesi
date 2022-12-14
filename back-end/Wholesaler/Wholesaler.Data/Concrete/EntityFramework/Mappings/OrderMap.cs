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
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).ValueGeneratedOnAdd();
            builder.Property(o => o.CreatedByName).IsRequired();
            builder.Property(o => o.CreatedByName).HasMaxLength(50);
            builder.Property(o => o.ModifiedByName).IsRequired();
            builder.Property(o => o.ModifiedByName).HasMaxLength(50);
            builder.Property(o => o.CreatedDate).IsRequired();
            builder.Property(o => o.ModifiededDate).IsRequired();
            builder.Property(o => o.isActive).IsRequired();
            builder.Property(o => o.isDeleted).IsRequired();
            builder.HasOne<WholesalerUser>(o => o.WholesalerUser).WithMany(w => w.Orders).HasForeignKey(o => o.WholesalerUserId);
            builder.HasOne<GroceryStoreUser>(o => o.GroceryStoreUser).WithMany(g => g.Orders).HasForeignKey(o => o.GroceryStoreUserId);
            builder.HasOne<Delivery>(o => o.Delivery).WithOne(d => d.Order).HasForeignKey<Order>(d => d.DeliveryId);
            builder.ToTable("Orders");
        }
    }
}
