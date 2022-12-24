using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace markettoptanci.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string DeliveryStatus { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

        [ForeignKey("GroceryStoreUser")]
        public int GroceryStoreUserId { get; set; }
        public GroceryStoreUser GroceryStoreUser { get; set; }

        [ForeignKey("WholesalerUser")]
        public int WholesalerUserId { get; set; }
        public WholesalerUser WholesalerUser { get; set; }

        [ForeignKey("Delivery")]
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
