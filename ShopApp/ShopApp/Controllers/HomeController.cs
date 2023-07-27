using Microsoft.AspNetCore.Mvc;
using ShopApp.Data;
using ShopApp.Models;
using ShopApp.ViewModels;
using System;
using System.Collections.Generic;

namespace ShopApp.Controllers
{
    public class HomeController : Controller
    { 
        public IActionResult Index()
        {

            var productViewModel = new ProductViewModel()
            {
                Products = ProductRepository.Products,
            };
            //ViewBag.Category = category;

            return View(productViewModel);

        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View("MyView");
        }


    }
}
