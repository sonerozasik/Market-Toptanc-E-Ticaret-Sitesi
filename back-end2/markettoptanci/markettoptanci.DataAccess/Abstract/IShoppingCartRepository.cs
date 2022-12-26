using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using markettoptanci.Entities;

namespace markettoptanci.DataAccess.Abstract
{
    public interface IShoppingCartRepository
    {
        List<ShoppingCart> GetAllShoppingCarts();

        ShoppingCart GetShoppingCartById(int id);

        ShoppingCart CreateShoppingCart(ShoppingCart shoppingCart);

        ShoppingCart UpdateShoppingCart(ShoppingCart shoppingCart);

        ShoppingCart DeleteShoppingCart(int id);

        ShoppingCart AddCartItem(CartItem cartItem);

    }
}
