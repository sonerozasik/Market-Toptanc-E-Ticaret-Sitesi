using markettoptanci.DataAccess.Abstract;
using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Concrete
{
    public class OrderItemRepository : IOrderItemRepository
    {
        public OrderItem CreateOrderItem(OrderItem orderItem)
        {
            using (var orderItemDbContext = new UserDbContext())
            {
                orderItemDbContext.OrderItems.Add(orderItem);
                orderItemDbContext.SaveChanges();
                return orderItem;
            }
        }

        public OrderItem DeleteOrderItem(int id)
        {
            using (var orderItemDbContext = new UserDbContext())
            {
                var deleteOrderItem = GetOrderItemById(id);
                orderItemDbContext.OrderItems.Remove(deleteOrderItem);
                orderItemDbContext.SaveChanges();
                return deleteOrderItem;
            }
        }

        public OrderItem GetOrderItemById(int id)
        {
            using (var orderItemDbContext = new UserDbContext())
            {
                return orderItemDbContext.OrderItems.Find(id);
            }
        }

        public List<OrderItem> GetAllOrderItems()
        {
            using (var orderItemDbContext = new UserDbContext())
            {
                return orderItemDbContext.OrderItems.ToList();
            }
        }

        public OrderItem UpdateOrderItem(OrderItem orderItem)
        {
            using (var orderItemDbContext = new UserDbContext())
            {
                orderItemDbContext.OrderItems.Update(orderItem);
                orderItemDbContext.SaveChanges();
                return orderItem;
            }
        }
    }
}
