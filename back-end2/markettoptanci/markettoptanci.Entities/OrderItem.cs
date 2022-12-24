using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace markettoptanci.Entities
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public float Quantity { get; set; }
        public double TotalPrice { get { return TotalPrice; } set { TotalPrice = Quantity * Product.Price; } }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("Return")]
        public int ReturnId { get; set; }
        public Return Return { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
