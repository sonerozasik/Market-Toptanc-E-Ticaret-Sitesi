﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace markettoptanci.Entities
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        public List<CartItem> CartItems   { get; set; }
        public GroceryStoreUser GroceryStoreUser { get; set; }
        public double? TotalPrice
        {
            get; set;
            /*get { return TotalPrice; }
            set
            {
                TotalPrice = 0;
                foreach (var orderItem in CartItems)
                {
                    TotalPrice += orderItem.TotalPrice;
                }
            }*/
        }

        public ShoppingCart()
        {
            CartItems = new List<CartItem>();
        }
    }
}
