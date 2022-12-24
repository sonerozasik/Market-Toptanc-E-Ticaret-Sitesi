using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace markettoptanci.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string ProductName { get; set; }
        public double Price { get; set; }

        [MaxLength(50)]
        public string Thumbnail { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [ForeignKey("WholesalerUser")]
        public int WholesalerUserId { get; set; }
        public WholeSalerUser WholesalerUser { get; set; }

        [ForeignKey("Stock")]
        public int StockId { get; set; }
        public Stock Stock { get; set; }

    }
}
