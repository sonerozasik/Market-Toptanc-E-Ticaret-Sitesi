﻿using markettoptanci.DataAccess.Abstract;
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

        public List<Order> GetOrdersByGroceryStoreUserId(int groceryStoreUserId)
        {
            using (var orderDbContext = new UserDbContext())
            {
                List<Order> orders = orderDbContext.Orders.Where(o => o.GroceryStoreUserId == groceryStoreUserId).ToList();
                foreach(var order in orders)
                {
                    order.OrderItems = orderDbContext.OrderItems.Where(o=>o.OrderId == order.Id).ToList();
                    order.WholeSalerUser = orderDbContext.WholeSalerUsers.FirstOrDefault(w => w.Id == order.WholeSalerUserId);

                    foreach (var orderItem in order.OrderItems)
                    {
                        orderItem.Product = orderDbContext.Products.FirstOrDefault(p=>p.Id == orderItem.ProductId);
                    }
                }
                return orders;
            }
        }

        public List<Order> GetOrdersByWholeSalerUserId(int wholeSalerUserId)
        {
            using (var orderDbContext = new UserDbContext())
            {
                List<Order> orders = orderDbContext.Orders.Where(o => o.WholeSalerUserId == wholeSalerUserId).ToList();

                foreach (var order in orders)
                {
                    order.OrderItems = orderDbContext.OrderItems.Where(o => o.OrderId == order.Id).ToList();
                    order.GroceryStoreUser = orderDbContext.GroceryStoreUsers.FirstOrDefault(g => g.Id == order.GroceryStoreUserId);

                    foreach (var orderItem in order.OrderItems)
                    {
                        orderItem.Product = orderDbContext.Products.FirstOrDefault(p => p.Id == orderItem.ProductId);
                    }
                }
                return orders;
            }
        }
    }
}
