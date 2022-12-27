using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Entities.Modals
{
    public class ProductWithStock
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public int WholeSalerUserId { get; set; }
        public int Quantity { get; set; }
        public string StockType { get; set; }
        public string Description { get; set; }

    }
}
