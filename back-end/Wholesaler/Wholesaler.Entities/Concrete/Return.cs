using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Shared.Entities.Abstract;

namespace Wholesaler.Entities.Concrete
{
    public class Return: EntityBase, IEntity
    {
        public string Status { get; set; }
        public int OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; }
        public int GroceryStoreUserId { get; set; }
        public GroceryStoreUser GroceryStoreUser { get; set; }
        public int WholesalerUserId { get; set; }
        public WholesalerUser WholesalerUser { get; set; }

    }
}
