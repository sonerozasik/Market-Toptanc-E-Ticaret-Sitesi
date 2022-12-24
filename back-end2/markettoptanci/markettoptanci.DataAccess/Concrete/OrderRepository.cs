using markettoptanci.DataAccess.Abstract;
using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Concrete
{
    public class OrderRepository : IOrderRepository
    {
        public Order CreateOrder(Order order)
        {
            using (var orderDbContext = new UserDbContext())
            {
                orderDbContext.Orders.Add(order);
                orderDbContext.SaveChanges();
                return order;
            }
        }

        public Order DeleteOrder(int id)
        {
            using (var orderDbContext = new UserDbContext())
            {
                var deleteOrder = GetOrderById(id);
                orderDbContext.Orders.Remove(deleteOrder);
                orderDbContext.SaveChanges();
                return deleteOrder;
            }
        }

        public Order GetOrderById(int id)
        {
            using (var orderDbContext = new UserDbContext())
            {
                return orderDbContext.Orders.Find(id);
            }
        }

        public List<Order> GetAllOrders()
        {
            using(var orderDbContext = new UserDbContext())
            {
                return orderDbContext.Orders.ToList();
            }
        }

        public Order UpdateOrder(Order order)
        {
            using (var orderDbContext = new UserDbContext())
            {
                orderDbContext.Orders.Update(order);
                orderDbContext.SaveChanges();
                return order;
            }
        }
    }
}
