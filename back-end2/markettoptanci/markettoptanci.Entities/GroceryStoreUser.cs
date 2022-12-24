using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Entities.Concrete;

namespace Wholesaler.Entities.Concrete
{
    public class GroceryStoreUser: User
    {
        public ICollection<Order> Orders { get; set; }
        public ICollection<Return> Returns { get; set; }
        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
