﻿using System;
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
        public double TotalPrice { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        //public Order? Order { get; set; }
    }
}
