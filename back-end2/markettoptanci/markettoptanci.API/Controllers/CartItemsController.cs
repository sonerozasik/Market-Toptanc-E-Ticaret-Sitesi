using markettoptanci.Business.Abstract;
using markettoptanci.Business.Concrete;
using markettoptanci.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace markettoptanci.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemsController : ControllerBase
    {
        private ICartItemService _cartItemService;
        public CartItemsController()
        {
            _cartItemService = new CartItemManager();
        }


        [HttpGet]
        public List<CartItem> GetAllCartItems()
        {
            return _cartItemService.GetAllCartItems();
        }

        [HttpGet("{id}")]
        public CartItem GetCartItemById(int id)
        {
            return _cartItemService.GetCartItemById(id);
        }

        [HttpPost]
        public CartItem CreateCartItem([FromBody] CartItem cartItem)
        {
            return _cartItemService.CreateCartItem(cartItem);
        }

        [HttpPut]
        public CartItem UpdateCartItem([FromBody] CartItem cartItem)
        {
            return _cartItemService.UpdateCartItem(cartItem);
        }

        [HttpDelete("{id}")]
        public CartItem DeleteCartItem(int id)
        {
            return _cartItemService.DeleteCartItem(id);
        }
    }
}

