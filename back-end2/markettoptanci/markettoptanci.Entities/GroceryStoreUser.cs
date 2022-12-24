using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Entities
{
    public class GroceryStoreUser
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public string StoreName { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public ICollection<Return>? Returns { get; set; }

        [ForeignKey("ShoppingCart")]
        public int? ShoppingCartId { get; set; }
        public ShoppingCart? ShoppingCart { get; set; }
    }
}
