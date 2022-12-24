using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Entities
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        public float Quantity { get; set; }
        public double TotalPrice { get { return TotalPrice; } set { TotalPrice = Quantity * Product.Price; } }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
