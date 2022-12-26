using markettoptanci.Business.Abstract;
using markettoptanci.Business.Concrete;
using markettoptanci.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace markettoptanci.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private IOrderService _orderService;
        public OrdersController()
        {
            _orderService = new OrderManager();
        }


        [HttpGet]
        public List<Order> GetAllOrders()
        {
            return _orderService.GetAllOrders();
        }

        [HttpGet("{id}")]
        public Order GetOrderById(int id)
        {
            return _orderService.GetOrderById(id);
        }

        [HttpPost]
        public Order CreateOrder([FromBody]Order order)
        {
            return _orderService.CreateOrder(order);
        }

        [HttpPut]
        public Order UpdateOrder([FromBody] Order order)
        {
            return _orderService.UpdateOrder(order);
        }

        [HttpDelete("{id}")]
        public Order DeleteOrder(int id)
        {
            return _orderService.DeleteOrder(id);
        }

        [HttpGet("byGsId/{id}")]
        public List<Order> GetOrdersByGroceryStoreUserId(int id)
        {
            return _orderService.GetOrdersByGroceryStoreUserId(id);
        }

        [HttpGet("byWsId/{id}")]
        public List<Order> GetOrdersByWholeSalerUserId(int id)
        {
            return _orderService.GetOrdersByWholeSalerUserId(id);
        }
    }
}

