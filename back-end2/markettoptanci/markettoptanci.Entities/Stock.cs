using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace markettoptanci.Entities
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string StockType { get; set; }
        public string Description { get; set; }
        public Product Product { get; set; }
    }
}
