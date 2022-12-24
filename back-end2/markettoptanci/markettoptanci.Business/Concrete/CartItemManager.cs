using markettoptanci.Business.Abstract;
using markettoptanci.DataAccess.Abstract;
using markettoptanci.DataAccess.Concrete;
using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Business.Concrete
{
    public class CartItemManager : ICartItemService
    {
        private ICartItemRepository _cartItemRepository;

        public CartItemManager()
        {
            _cartItemRepository = new CartItemRepository();
        }
        public CartItem CreateCartItem(CartItem cartItem)
        {
            return _cartItemRepository.CreateCartItem(cartItem);
        }

        public CartItem DeleteCartItem(int id)
        {
            return _cartItemRepository.DeleteCartItem(id);
        }

        public List<CartItem> GetAllCartItems()
        {
            return _cartItemRepository.GetAllCartItems();
        }

        public CartItem GetCartItemById(int id)
        {
            if (id > 0)
            {
                return _cartItemRepository.GetCartItemById(id);
            }

            throw new Exception("Id can not be less than 1!");


        }

        public CartItem UpdateCartItem(CartItem cartItem)
        {
            return _cartItemRepository.UpdateCartItem(cartItem);
        }
    }
}
