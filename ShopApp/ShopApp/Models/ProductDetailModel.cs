﻿using ShopApp.Entity;
using System.Collections.Generic;

namespace ShopApp.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }  

    }
}
