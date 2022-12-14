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
    public class StockMap : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedOnAdd();
            builder.Property(s => s.StockType).IsRequired();
            builder.Property(s => s.StockType).HasMaxLength(15);
            builder.Property(s => s.Quantity).IsRequired();
            builder.Property(s => s.Description).HasMaxLength(70);
            builder.Property(s => s.CreatedByName).IsRequired();
            builder.Property(s => s.CreatedByName).HasMaxLength(50);
            builder.Property(s => s.ModifiedByName).IsRequired();
            builder.Property(s => s.ModifiedByName).HasMaxLength(50);
            builder.Property(s => s.CreatedDate).IsRequired();
            builder.Property(s => s.ModifiededDate).IsRequired();
            builder.Property(s => s.isActive).IsRequired();
            builder.Property(s => s.isDeleted).IsRequired();
            builder.ToTable("Stocks");
        }
    }
}
