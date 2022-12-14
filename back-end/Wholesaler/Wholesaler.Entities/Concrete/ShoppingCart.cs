using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Shared.Entities.Abstract;

namespace Wholesaler.Entities.Concrete
{
    public class ShoppingCart: EntityBase, IEntity
    {
        public ICollection<CartItem> CartItems { get; set; }
        public GroceryStoreUser GroceryStoreUser { get; set; }
        public double TotalPrice
        {
            get { return TotalPrice; }
            set
            {
                TotalPrice = 0;
                foreach (var orderItem in CartItems)
                {
                    TotalPrice += orderItem.TotalPrice;
                }
            }
        }
    }
}
