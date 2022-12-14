using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Entities.Concrete;
using Wholesaler.Shared.Entities.Abstract;

namespace Wholesaler.Entities.Concrete
{
    public class Order: EntityBase, IEntity
    {
        public string DeliveryStatus { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public int GroceryStoreUserId { get; set; }
        public GroceryStoreUser GroceryStoreUser { get; set; }
        public int WholesalerUserId { get; set; }
        public WholesalerUser WholesalerUser { get; set; }
        public int DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
        public double TotalPrice { 
            get { return TotalPrice; } 
            set { 
                TotalPrice = 0;
                foreach (var orderItem in OrderItems)
                {
                    TotalPrice += orderItem.TotalPrice;
                }
            } 
        }
    }
}
