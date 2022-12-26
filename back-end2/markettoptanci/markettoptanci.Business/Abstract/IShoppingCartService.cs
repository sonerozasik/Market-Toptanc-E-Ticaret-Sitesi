using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Business.Abstract
{
    public interface IShoppingCartService
    {
        List<ShoppingCart> GetAllShoppingCarts();

        ShoppingCart GetShoppingCartById(int id);

        ShoppingCart CreateShoppingCart(ShoppingCart shoppingCart);

        ShoppingCart UpdateShoppingCart(ShoppingCart shoppingCart);

        ShoppingCart DeleteShoppingCart(int id);

        ShoppingCart AddCartItem(CartItem cartItem);

    }
}
