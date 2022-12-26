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
        public ICollection<OrderItem>? OrderItems { get; set; }

        [ForeignKey("GroceryStoreUser")]
        public int GroceryStoreUserId { get; set; }
        public GroceryStoreUser? GroceryStoreUser { get; set; }

        [ForeignKey("WholeSalerUser")]

        //todo s-->S
        public int WholeSalerUserId { get; set; }
        public WholeSalerUser? WholeSalerUser { get; set; }

        [ForeignKey("Delivery")]
        public int? DeliveryId { get; set; }
        public Delivery? Delivery { get; set; }
        public double TotalPrice { get; set; }

        //todo date
    }
}
