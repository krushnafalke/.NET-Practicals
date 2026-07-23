using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment12.Models;
using Microsoft.AspNetCore.Http;

namespace Assignment12.Controllers{

    public class HomeController : Controller
    {


        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                HttpContext.Session.SetString("User", username);
                return RedirectToAction("Stationery","Stationery");
            }
            ViewBag.Message = "Invalid username or password";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

    }
}
