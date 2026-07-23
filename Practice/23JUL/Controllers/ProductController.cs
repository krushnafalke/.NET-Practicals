using _23JUL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace _23JUL.Controllers 
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("User")))
            {
                return RedirectToAction("Login","Home");
            }
            List<Product> products = new List<Product>()
            {
                new Product{ ID = 1, Name = "Laptop",Price = 10000000},
                new Product{ ID = 2, Name = "Phone",Price = 80000},
                new Product{ ID = 3, Name = "Earphone",Price = 5000},
                new Product{ ID = 4, Name = "Charger",Price = 1000},
            };
           
            return View(products);
        }
    }
}

