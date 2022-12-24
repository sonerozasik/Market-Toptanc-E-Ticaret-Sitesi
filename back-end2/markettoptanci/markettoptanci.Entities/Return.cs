using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wholesaler.Entities.Concrete
{
    public class Return
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }

        public OrderItem OrderItem { get; set; }

        [ForeignKey("GroceryStoreUser")]
        public int GroceryStoreUserId { get; set; }
        public GroceryStoreUser GroceryStoreUser { get; set; }

        [ForeignKey("WholesalerUser")]
        public int WholesalerUserId { get; set; }
        public WholesalerUser WholesalerUser { get; set; }

    }
}
