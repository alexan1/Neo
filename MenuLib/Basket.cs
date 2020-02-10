using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuLib
{
    public class Basket
    {
        //private Product prodict;

        public ICollection<CartItem> Items { get; set; } = new List<CartItem>();

        public void AddItem(int j)
        {                
            var product = Menu.ProductMenu.FirstOrDefault(p => p.Id == j);
            var item = Items.FirstOrDefault(i => i.ItemProduct == product);
            if (item != null)
                item.Quantity++;
            else
            {                        
                Items.Add(item);
            }                       
        }

        public void RemoveItem(Product product)
        {
            var item = Items.FirstOrDefault(p => p.ItemProduct == product);
            if (item != null)
                item.Quantity--;            
        }
    }
}
