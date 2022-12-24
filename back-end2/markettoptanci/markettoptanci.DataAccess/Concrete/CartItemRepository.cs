using markettoptanci.DataAccess.Abstract;
using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Entities.Concrete;

namespace markettoptanci.DataAccess.Concrete
{
    public class CartItemRepository : ICartItemRepository
    {
        public CartItem CreateCartItem(CartItem cartItem)
        {
            using (var cartItemDbContext = new UserDbContext())
            {
                cartItemDbContext.CartItems.Add(cartItem);
                cartItemDbContext.SaveChanges();
                return cartItem;
            }
        }

        public CartItem DeleteCartItem(int id)
        {
            using (var cartItemDbContext = new UserDbContext())
            {
                var deleteCartItem = GetCartItemById(id);
                cartItemDbContext.CartItems.Remove(deleteCartItem);
                cartItemDbContext.SaveChanges();
                return deleteCartItem;
            }
        }

        public CartItem GetCartItemById(int id)
        {
            using (var cartItemDbContext = new UserDbContext())
            {
                return cartItemDbContext.CartItems.Find(id);
            }
        }

        public List<CartItem> GetAllCartItems()
        {
            using (var cartItemDbContext = new UserDbContext())
            {
                return cartItemDbContext.CartItems.ToList();
            }
        }

        public CartItem UpdateCartItem(CartItem CartItem)
        {
            using (var cartItemDbContext = new UserDbContext())
            {
                cartItemDbContext.CartItems.Update(CartItem);
                cartItemDbContext.SaveChanges();
                return CartItem;
            }
        }
    }
}
