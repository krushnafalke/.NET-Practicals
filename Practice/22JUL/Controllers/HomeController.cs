// using System.Diagnostics;
// using Microsoft.AspNetCore.Mvc;
// using _22JUL.Models;


// namespace _22JUL.Controllers;

// public class HomeController : Controller
// {
   

//     public IActionResult Index()
//     {
//         return View();
//     }
    
//     [HttpPost]

//     public ActionResult Index(Product product)
//     {
//         if (ModelState.IsValid)
//         {
//             return Content("Product:   " +product.Name + "  ,Price : "+product.Price   + "  ,category: "+product.Category   + "  ,Stock:" + product.Stock );
//         }
//         return View(product);
//     }

// }

using Microsoft.AspNetCore.Mvc;
using _22JUL.Models;

namespace _22JUL.Controllers
{
    public class HomeController : Controller
    {
        static List<Stationery> stationeryList = new List<Stationery>();

        [HttpGet]
        public IActionResult Stationery()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Stationery(Stationery stationery)
        {
            if (ModelState.IsValid)
            {
                stationeryList.Add(stationery);

                return Content(
                     $"Item Name : {stationery.ItemName} , " +$"Brand : {stationery.Category} , " +$"Price : {stationery.Price} , " +$"Quantity : {stationery.Stock}"
                );
            }

            return View(stationery);
        }
    }
}
