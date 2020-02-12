using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLib
{
    public class CartItem
    {
        public CartItem(Product prod, int num)
        {
            ItemProduct = prod;
            Quantity = num;
        }

        public Product ItemProduct { get; set; }
        public int Quantity { get; set; }
    }
}
