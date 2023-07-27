using ShopApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ShopApp.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product { ProductId = 1, Name = "Iphone 11 ", Price = 2300, Description = "Oluru var", IsApproved = false, ImageUrl = "1.jpg" , CategoryId =1 },
                new Product { ProductId = 2, Name = "Iphone 12", Price = 4000, Description = "eski versiyon", IsApproved = true  ,ImageUrl = "2.jpg" ,CategoryId =1 },
                new Product { ProductId = 3, Name = "Iphone 13", Price = 8000, Description = "eski versiyon", IsApproved = true , ImageUrl = "3.jpg",CategoryId =1 },
                new Product { ProductId = 4, Name = "Iphone 14", Price = 48000, Description = "eski versiyon", ImageUrl = "4.jpg", CategoryId =1 },
                new Product { ProductId = 5, Name = "Iphone X", Price = 48000, Description = "eski versiyon", ImageUrl = "4.jpg", CategoryId =1 },
                new Product { ProductId =6, Name = "Lenova 1", Price = 2300, Description = "Ideapading Game", IsApproved = false, ImageUrl = "1.jpg" , CategoryId =2 },
                new Product { ProductId = 7, Name = "Lenova 2", Price = 4000, Description = "i7 127000h", IsApproved = true  ,ImageUrl = "2.jpg" ,CategoryId =2 },
                new Product { ProductId = 8, Name = "Lenova 3 ", Price = 8000, Description = "eski versiyon", IsApproved = true , ImageUrl = "3.jpg",CategoryId =2 },
                new Product { ProductId = 9, Name = "Lenova 4", Price = 48000, Description = "eski", ImageUrl = "4.jpg", CategoryId =2 }

            };
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);


        }

    }
}
