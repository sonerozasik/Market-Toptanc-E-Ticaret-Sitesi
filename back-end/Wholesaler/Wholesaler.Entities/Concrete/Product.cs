using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Shared.Entities.Abstract;

namespace Wholesaler.Entities.Concrete
{
    public class Product:EntityBase, IEntity
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Thumbnail { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int WholesalerUserId { get; set; }
        public WholesalerUser WholesalerUser { get; set; }
        public int StockId { get; set; }
        public Stock Stock { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

    }
}
