using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Business.Abstract
{
    public interface IOrderItemService
    {
        List<OrderItem> GetAllOrderItems();

        OrderItem GetOrderItemById(int id);

        OrderItem CreateOrderItem(OrderItem orderItem);

        OrderItem UpdateOrderItem(OrderItem orderItem);

        OrderItem DeleteOrderItem(int id);
    }
}
