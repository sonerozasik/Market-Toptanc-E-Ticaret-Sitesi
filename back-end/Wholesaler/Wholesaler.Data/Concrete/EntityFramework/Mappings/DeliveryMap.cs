using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Entities.Concrete;

namespace Wholesaler.Data.Concrete.EntityFramework.Mappings
{
    public class DeliveryMap : IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).ValueGeneratedOnAdd();
            builder.Property(d => d.Status).IsRequired();
            builder.Property(d => d.TrackNumber).IsRequired();
            builder.Property(d => d.CompanyName).IsRequired();
            builder.Property(d => d.Status).HasMaxLength(30);
            builder.Property(d => d.TrackNumber).HasMaxLength(30);
            builder.Property(d => d.CompanyName).HasMaxLength(70);
            builder.Property(d => d.CreatedByName).IsRequired();
            builder.Property(d => d.CreatedByName).HasMaxLength(50);
            builder.Property(d => d.ModifiedByName).IsRequired();
            builder.Property(d => d.ModifiedByName).HasMaxLength(50);
            builder.Property(d => d.CreatedDate).IsRequired();
            builder.Property(d => d.ModifiededDate).IsRequired();
            builder.Property(d => d.isActive).IsRequired();
            builder.Property(d => d.isDeleted).IsRequired();
            builder.ToTable("Deliveries");
        }
    }
}
