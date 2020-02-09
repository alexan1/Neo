using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuLib
{
    public class Basket
    {
        //private Product prodict;

        public ICollection<CartItem> Items { get; set; }

        public void AddItem()
        {
            Console.Write("veuillez entrer le numéro de produit");
            var id = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine(" ");
            if (Int32.TryParse(id, out int j))
            {
                if (Items != null)
                {
                    var item = Items.FirstOrDefault(p => p.ItemProduct.Id == j);
                    if (item != null)
                        item.Quantity++;
                    else
                        Items.Add(item);
                }
                else
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
