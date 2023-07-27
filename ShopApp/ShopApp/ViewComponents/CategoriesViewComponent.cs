using Microsoft.AspNetCore.Mvc;
using ShopApp.Data;
using ShopApp.Models;
using System.Collections.Generic;

namespace ShopApp.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["action"].ToString()=="list")
            ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);


        }


    }
}
