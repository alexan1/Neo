﻿using System;

namespace MenuLib
{
    public class Product
    {
        public int Id { get; set; }
        public string  Name{ get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int MaxQuantity { get; set; }
    }
}