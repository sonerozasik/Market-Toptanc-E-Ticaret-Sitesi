using markettoptanci.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess
{
    public class UserDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(@"User ID =postgres;Password=1234;Server=localhost;Port=5432;Database=Wholesaler_Ecommerce;Integrated Security=true;Pooling=true");

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<GroceryStoreUser> GroceryStoreUsers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<WholeSalerUser> WholeSalerUsers { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Return> Returns { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Stock> Stocks { get; set; }

    }
}
