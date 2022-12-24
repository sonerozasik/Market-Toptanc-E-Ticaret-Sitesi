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
    public class OrderItemsController
    {
        private IOrderItemService _orderItemService;
        public OrderItemsController()
        {
            _orderItemService = new OrderItemManager();
        }


        [HttpGet]
        public List<OrderItem> GetAllOrderItems()
        {
            return _orderItemService.GetAllOrderItems();
        }

        [HttpGet("{id}")]
        public OrderItem GetOrderItemById(int id)
        {
            return _orderItemService.GetOrderItemById(id);
        }

        [HttpPost]
        public OrderItem CreateOrderItem([FromBody] OrderItem orderItem)
        {
            return _orderItemService.CreateOrderItem(orderItem);
        }

        [HttpPut]
        public OrderItem UpdateOrderItem([FromBody] OrderItem orderItem)
        {
            return _orderItemService.UpdateOrderItem(orderItem);
        }

        [HttpDelete("{id}")]
        public OrderItem DeleteOrderItem(int id)
        {
            return _orderItemService.DeleteOrderItem(id);
        }
    }
}
