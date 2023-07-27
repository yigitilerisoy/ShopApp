using Microsoft.AspNetCore.Mvc;
using ShopApp.Data;
using ShopApp.Models;
using ShopApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopApp.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index()
        {
            var product = new Product { Name = "Iphone X", Price = 2000, Description = "Güzel Telefon abii" };

            //ViewData["Category"] = "Telefonlar";

            //ViewData["Product"] = product;

            ViewBag.Category = "Telefonlar";
            //ViewBag.Product= product;


            return View(product);
        }

        public IActionResult list(int? id)
        {
            //Console.WriteLine(RouteData.Values["controller"]);
            //Console.WriteLine(RouteData.Values["action"]);
            //Console.WriteLine(RouteData.Values["id"]);


            var products = ProductRepository.Products;
            if(id!=null)
            {
                products = products.Where(p=> p.CategoryId==id).ToList();
            }

            var productViewModel = new ProductViewModel()
            {
                Products = products
            };

            //ViewBag.Category = category;

            return View(productViewModel);
        }

        public IActionResult Details(int id)
        {
            return View(ProductRepository.GetProductById(id));
        }
    }
}
