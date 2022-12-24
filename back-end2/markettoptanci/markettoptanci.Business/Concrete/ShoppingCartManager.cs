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
    public class ShoppingCartManager : IShoppingCartService
    {
        private IShoppingCartRepository _shoppingCartRepository;

        public ShoppingCartManager()
        {
            _shoppingCartRepository = new ShoppingCartRepository();
        }
        public ShoppingCart CreateShoppingCart(ShoppingCart shoppingCart)
        {
            return _shoppingCartRepository.CreateShoppingCart(shoppingCart);
        }

        public ShoppingCart DeleteShoppingCart(int id)
        {
            return _shoppingCartRepository.DeleteShoppingCart(id);
        }

        public List<ShoppingCart> GetAllShoppingCarts()
        {
            return _shoppingCartRepository.GetAllShoppingCarts();
        }

        public ShoppingCart GetShoppingCartById(int id)
        {
            if (id > 0)
            {
                return _shoppingCartRepository.GetShoppingCartById(id);
            }

            throw new Exception("Id can not be less than 1!");


        }

        public ShoppingCart UpdateShoppingCart(ShoppingCart shoppingCart)
        {
            return _shoppingCartRepository.UpdateShoppingCart(shoppingCart);
        }
    }
}
