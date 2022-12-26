using markettoptanci.Business.Abstract;
using markettoptanci.Business.Concrete;
using markettoptanci.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace markettoptanci.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartsController
    {
        private IShoppingCartService _shoppingCartService;
        public ShoppingCartsController()
        {
            _shoppingCartService = new ShoppingCartManager();
        }


        [HttpGet]
        public List<ShoppingCart> GetAllShoppingCarts()
        {
            return _shoppingCartService.GetAllShoppingCarts();
        }

        [HttpGet("{id}")]
        public ShoppingCart GetShoppingCartById(int id)
        {
            return _shoppingCartService.GetShoppingCartById(id);
        }

        [HttpPost]
        public ShoppingCart CreateShoppingCart([FromBody] ShoppingCart shoppingCart)
        {
            return _shoppingCartService.CreateShoppingCart(shoppingCart);
        }

        [HttpPut]
        public ShoppingCart UpdateShoppingCart([FromBody] ShoppingCart shoppingCart)
        {
            return _shoppingCartService.UpdateShoppingCart(shoppingCart);
        }

        [HttpDelete("{id}")]
        public ShoppingCart DeleteShoppingCart(int id)
        {
            return _shoppingCartService.DeleteShoppingCart(id);
        }

        [HttpPost("addItem")]
        public ShoppingCart AddCartItem([FromBody] CartItem cartItem)
        {
            return _shoppingCartService.AddCartItem(cartItem);
        }

    }
}
