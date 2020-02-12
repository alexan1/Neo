using System;

namespace MenuLib
{
    public class Product
    {
        public Product(int id, string name, decimal price, int max)
        {
            Id = id;
            Name = name;
            Price = price;
            MaxQuantity = max;
            //Quantity = 0;
        }
        public int Id { get; set; }
        public string  Name{ get; set; }
        public decimal Price { get; set; }
        public int MaxQuantity { get; set; }        
    }
}
