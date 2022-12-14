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
    public class WholesalerUserMap : IEntityTypeConfiguration<WholesalerUser>
    {
        public void Configure(EntityTypeBuilder<WholesalerUser> builder)
        {
            builder.HasKey(w => w.Id);
            builder.Property(w => w.Id).ValueGeneratedOnAdd();
            builder.Property(w => w.FirstName).HasMaxLength(30);
            builder.Property(w => w.LastName).HasMaxLength(30);
            builder.Property(w => w.FirstName).IsRequired();
            builder.Property(w => w.LastName).IsRequired();
            builder.Property(w => w.Email).IsRequired();
            builder.Property(w => w.Email).HasMaxLength(100);
            builder.Property(w => w.Picture).IsRequired();
            builder.Property(w => w.Picture).HasMaxLength(250);
            builder.Property(w => w.UserName).HasMaxLength(50);
            builder.Property(w => w.UserName).IsRequired();
            builder.Property(w => w.PhoneNumber).IsRequired();
            builder.Property(w => w.PhoneNumber).HasMaxLength(15);
            builder.Property(w => w.City).HasMaxLength(30);
            builder.Property(w => w.District).HasMaxLength(50);
            builder.Property(w => w.Street).HasMaxLength(70);
            builder.Property(w => w.City).IsRequired();
            builder.Property(w => w.District).IsRequired();
            builder.Property(w => w.Street).IsRequired();
            builder.Property(w => w.ZipCode).HasMaxLength(10);
            builder.Property(w => w.ZipCode).IsRequired();
            builder.Property(w => w.CreatedByName).IsRequired();
            builder.Property(w => w.CreatedByName).HasMaxLength(50);
            builder.Property(w => w.ModifiedByName).IsRequired();
            builder.Property(w => w.ModifiedByName).HasMaxLength(50);
            builder.Property(w => w.CreatedDate).IsRequired();
            builder.Property(w => w.ModifiededDate).IsRequired();
            builder.Property(w => w.isActive).IsRequired();
            builder.Property(w => w.isDeleted).IsRequired();
            builder.ToTable("WholesalerUsers");


        }
    }
}
