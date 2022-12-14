using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Shared.Entities.Abstract;

namespace Wholesaler.Entities.Concrete
{
    public class Stock: EntityBase, IEntity
    {
        public int Quantity { get; set; }
        public string StockType { get; set; }
        public string Description { get; set; }
        public Product Product { get; set; }
    }
}
