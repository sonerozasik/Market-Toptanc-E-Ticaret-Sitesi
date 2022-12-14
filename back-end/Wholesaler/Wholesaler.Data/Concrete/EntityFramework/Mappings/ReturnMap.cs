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
    public class ReturnMap : IEntityTypeConfiguration<Return>
    {
        public void Configure(EntityTypeBuilder<Return> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.Status).IsRequired();
            builder.Property(r => r.CreatedByName).IsRequired();
            builder.Property(r => r.CreatedByName).HasMaxLength(50);
            builder.Property(r => r.ModifiedByName).IsRequired();
            builder.Property(r => r.ModifiedByName).HasMaxLength(50);
            builder.Property(r => r.CreatedDate).IsRequired();
            builder.Property(r => r.ModifiededDate).IsRequired();
            builder.Property(r => r.isActive).IsRequired();
            builder.Property(r => r.isDeleted).IsRequired();
            builder.HasOne<GroceryStoreUser>(r => r.GroceryStoreUser).WithMany(g => g.Returns).HasForeignKey(r => r.GroceryStoreUserId);
            builder.HasOne<WholesalerUser>(r => r.WholesalerUser).WithMany(g => g.Returns).HasForeignKey(r => r.WholesalerUserId);
            builder.ToTable("Returns");
        }
    }
}
