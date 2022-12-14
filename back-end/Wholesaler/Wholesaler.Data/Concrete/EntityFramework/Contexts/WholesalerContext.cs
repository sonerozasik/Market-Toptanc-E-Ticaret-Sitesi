using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Entities.Concrete;

namespace Wholesaler.Data.Concrete.EntityFramework.Contexts
{
    public class WholesalerContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<GroceryStoreUser> GroceryStoreUsers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<WholesalerUser> WholesalerUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"User ID =postgres;Password=Ly756834219;Server=localhost;Port=5432;Database=Wholesaler_Ecommerce;Integrated Security=true;Pooling=true");
        }
    }
}
