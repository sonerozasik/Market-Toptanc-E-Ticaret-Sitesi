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
                ShoppingCart shoppingCart = shoppingCartDbContext.ShoppingCarts.Find(id);
                shoppingCart.CartItems = shoppingCartDbContext.CartItems.Where(ci => ci.ShoppingCartId == id).ToList();
                foreach(var cartItem in shoppingCart.CartItems)
                {
                    cartItem.Product = shoppingCartDbContext.Products.Find(cartItem.ProductId);
                }
                return shoppingCart;
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

        //todo not necessery
        public ShoppingCart AddCartItem(CartItem cartItem)
        {
            using (var shoppingCartDbContext = new UserDbContext())
            {
                ShoppingCart cart = new ShoppingCart();
                cart = shoppingCartDbContext.ShoppingCarts.Find(cartItem.ShoppingCartId);
                cart.CartItems.Add(cartItem);
                shoppingCartDbContext.CartItems.Add(cartItem);
                shoppingCartDbContext.SaveChanges();
                return cart;
            }
        }
    }
}
