﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopApp.Business.Abstract;
using ShopApp.Entity;
using ShopApp.Models;
using System.Linq;

namespace ShopApp.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _productService;

        public ShopController(IProductService productService)
        {
            this._productService = productService;
        }

        public IActionResult List(string category,int page=1)
        {
            const int pageSize = 2;
            var productViewModel = new ProductListViewModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems = _productService.GetCountByCategory(category),
                    CurrentPage = page,
                    ItemsPerPage= pageSize,
                    CurrentCategory = category
                },

                Products = _productService.GetProductsByCategory(category,page,pageSize)
            };

            return View(productViewModel);
        }

        public ActionResult Details(string url)
        {
            if (url == null)
            {
                return NotFound();
            }
            Product product = _productService.GetProductDetails(url);

            if (product == null)
            {
                return NotFound();
            }
            return View(new ProductDetailModel{
                Product= product,
                Categories = product.ProductCategories.Select(i => i.Category).ToList()
            });


        }

        public IActionResult Search(string q)
        {
            var productViewModel = new ProductListViewModel()
            {
               
                Products = _productService.GetSearchResult(q)
            };

            return View(productViewModel);
        }
    }
}