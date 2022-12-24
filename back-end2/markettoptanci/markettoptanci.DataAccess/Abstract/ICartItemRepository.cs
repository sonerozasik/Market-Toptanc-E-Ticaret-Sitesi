using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Entities.Concrete;

namespace markettoptanci.DataAccess.Abstract
{
    public interface ICartItemRepository
    {
        List<CartItem> GetAllCartItems();

        CartItem GetCartItemById(int id);

        CartItem CreateCartItem(CartItem cartItem);

        CartItem UpdateCartItem(CartItem cartItem);

        CartItem DeleteCartItem(int id);
    }
}
