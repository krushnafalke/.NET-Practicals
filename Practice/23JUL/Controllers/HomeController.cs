using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _23JUL.Models;
using Microsoft.AspNetCore.Http;

namespace _23JUL.Controllers
{
   
    public class HomeController : Controller
    {
    
        //GET : login
        public IActionResult Login()
        {
            return View();
        }

        //POST : login
        // [HttpPost]
        // public IActionResult Login(string username, string password)
        // {
        //     if(string.IsNullOrEmpty(HttpContext.Session.GetString("User")))
        //     {
                
        //         return RedirectToAction("Login","Home");
        //     }
        //     ViewBag.Message = "Invalid username or password";
        //     return View();
        // }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                HttpContext.Session.SetString("User", username);
                return RedirectToAction("Index", "Product");
            }

            ViewBag.Message = "Invalid username or password";
            return View();
        }

    
    }
}
