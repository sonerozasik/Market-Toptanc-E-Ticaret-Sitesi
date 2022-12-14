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
    public class GroceryStoreUserMap : IEntityTypeConfiguration<GroceryStoreUser>
    {
        public void Configure(EntityTypeBuilder<GroceryStoreUser> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Id).ValueGeneratedOnAdd();
            builder.Property(g => g.FirstName).HasMaxLength(30);
            builder.Property(g => g.LastName).HasMaxLength(30);
            builder.Property(g => g.FirstName).IsRequired();
            builder.Property(g => g.LastName).IsRequired();
            builder.Property(g => g.Email).IsRequired();
            builder.Property(g => g.Email).HasMaxLength(100);
            builder.Property(g => g.Picture).IsRequired();
            builder.Property(g => g.Picture).HasMaxLength(250);
            builder.Property(g => g.UserName).HasMaxLength(50);
            builder.Property(g => g.UserName).IsRequired();
            builder.Property(g => g.PhoneNumber).IsRequired();
            builder.Property(g => g.PhoneNumber).HasMaxLength(15);
            builder.Property(g => g.City).HasMaxLength(30);
            builder.Property(g => g.District).HasMaxLength(50);
            builder.Property(g => g.Street).HasMaxLength(70);
            builder.Property(g => g.City).IsRequired();
            builder.Property(g => g.District).IsRequired();
            builder.Property(g => g.Street).IsRequired();
            builder.Property(g => g.ZipCode).HasMaxLength(10);
            builder.Property(g => g.ZipCode).IsRequired();
            builder.Property(g => g.CreatedByName).IsRequired();
            builder.Property(g => g.CreatedByName).HasMaxLength(50);
            builder.Property(g => g.ModifiedByName).IsRequired();
            builder.Property(g => g.ModifiedByName).HasMaxLength(50);
            builder.Property(g => g.CreatedDate).IsRequired();
            builder.Property(g => g.ModifiededDate).IsRequired();
            builder.Property(g => g.isActive).IsRequired();
            builder.Property(g => g.isDeleted).IsRequired();
            builder.HasOne<ShoppingCart>(g => g.ShoppingCart).WithOne(s => s.GroceryStoreUser).HasForeignKey<GroceryStoreUser>(s => s.ShoppingCartId);

            builder.ToTable("GroceryStoreUsers");
        }
    }
}
