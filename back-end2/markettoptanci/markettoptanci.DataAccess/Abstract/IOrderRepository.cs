﻿using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Abstract
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrders();

        Order GetOrderById(int id);

        Order CreateOrder(Order order);

        Order UpdateOrder(Order order);

        Order DeleteOrder(int id);   
    }
}
