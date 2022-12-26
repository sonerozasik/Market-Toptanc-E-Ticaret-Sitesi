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
    public class OrderManager: IOrderService
    {
        private IOrderRepository _orderRepository;

        public OrderManager()
        {
            _orderRepository = new OrderRepository();
        }
        public Order CreateOrder(Order order)
        {
            return _orderRepository.CreateOrder(order);
        }

        public Order DeleteOrder(int id)
        {
            return _orderRepository.DeleteOrder(id);
        }

        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public Order GetOrderById(int id)
        {
            if (id > 0)
            {
                return _orderRepository.GetOrderById(id);
            }

            throw new Exception("Id can not be less than 1!");

            
        }

        public Order UpdateOrder(Order order)
        {
            return _orderRepository.UpdateOrder(order);
        }


        public List<Order> GetOrdersByGroceryStoreUserId(int groceryStoreUserId)
        {
            return _orderRepository.GetOrdersByGroceryStoreUserId(groceryStoreUserId);
        }

        public List<Order> GetOrdersByWholeSalerUserId(int wholeSalerUserId)
        {
            return _orderRepository.GetOrdersByWholeSalerUserId(wholeSalerUserId);
        }
    }
}
