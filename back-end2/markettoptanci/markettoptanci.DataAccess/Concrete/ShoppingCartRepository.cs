using markettoptanci.DataAccess.Abstract;
using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Concrete
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        public ShoppingCart CreateShoppingCart(ShoppingCart shoppingCart)
        {
            using (var shoppingCartDbContext = new UserDbContext())
            {
                shoppingCartDbContext.ShoppingCarts.Add(shoppingCart);
                shoppingCartDbContext.SaveChanges();
                return shoppingCart;
            }
        }

        public ShoppingCart DeleteShoppingCart(int id)
        {
            using (var shoppingCartDbContext = new UserDbContext())
            {
                var deleteShoppingCart = GetShoppingCartById(id);
                shoppingCartDbContext.ShoppingCarts.Remove(deleteShoppingCart);
                shoppingCartDbContext.SaveChanges();
                return deleteShoppingCart;
            }
        }

        public ShoppingCart GetShoppingCartById(int id)
        {
            using (var shoppingCartDbContext = new UserDbContext())
            {
                return shoppingCartDbContext.ShoppingCarts.Find(id);
            }
        }

        public List<ShoppingCart> GetAllShoppingCarts()
        {
            using (var shoppingCartDbContext = new UserDbContext())
            {
                return shoppingCartDbContext.ShoppingCarts.ToList();
            }
        }

        public ShoppingCart UpdateShoppingCart(ShoppingCart shoppingCart)
        {
            using (var shoppingCartDbContext = new UserDbContext())
            {
                shoppingCartDbContext.ShoppingCarts.Update(shoppingCart);
                shoppingCartDbContext.SaveChanges();
                return shoppingCart;
            }
        }
    }
}
