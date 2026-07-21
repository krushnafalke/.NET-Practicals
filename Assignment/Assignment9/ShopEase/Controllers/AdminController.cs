using Microsoft.AspNetCore.Mvc;

namespace ShopEase.Controllers
{
    public class AdminController : Controller
    {
        private string username = "admin";
        private string password = "admin123";

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == this.username && password == this.password)
            {
                return RedirectToAction("Dashboard");
            }

            ViewBag.Error = "Invalid Username or Password";
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}