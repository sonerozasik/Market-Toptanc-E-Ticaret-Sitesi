using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Entities.Concrete;
using Wholesaler.Shared.Entities.Abstract;

namespace Wholesaler.Entities.Concrete
{
    public class OrderItem: EntityBase, IEntity
    {
        public float Quantity { get; set; }
        public double TotalPrice { get { return TotalPrice; } set { TotalPrice = Quantity * Product.Price; } }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ReturnId { get; set; }
        public Return Return { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
