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
    public class OrderItemManager : IOrderItemService
    {
        private IOrderItemRepository _orderItemRepository;

        public OrderItemManager()
        {
            _orderItemRepository = new OrderItemRepository();
        }
        public OrderItem CreateOrderItem(OrderItem orderItem)
        {
            return _orderItemRepository.CreateOrderItem(orderItem);
        }

        public OrderItem DeleteOrderItem(int id)
        {
            return _orderItemRepository.DeleteOrderItem(id);
        }

        public List<OrderItem> GetAllOrderItems()
        {
            return _orderItemRepository.GetAllOrderItems();
        }

        public OrderItem GetOrderItemById(int id)
        {
            if (id > 0)
            {
                return _orderItemRepository.GetOrderItemById(id);
            }

            throw new Exception("Id can not be less than 1!");


        }

        public OrderItem UpdateOrderItem(OrderItem orderItem)
        {
            return _orderItemRepository.UpdateOrderItem(orderItem);
        }
    }
}
