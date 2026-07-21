using Microsoft.AspNetCore.Mvc;
using ShopEase.Models;

namespace ShopEase.Controllers
{
    public class CustomerController : Controller
    {
        public static List<Customer> customers = new List<Customer>();

        public IActionResult Index()
        {
            return View(customers);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Customer customer)
        {
            customer.CustomerId = customers.Count + 1;
            customers.Add(customer);

            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            Customer customer = customers.FirstOrDefault(c =>
                c.Email == email && c.Password == password);

            if (customer != null)
            {
                TempData["Name"] = customer.Name;
                return RedirectToAction("Dashboard");
            }

            ViewBag.Error = "Invalid Email or Password";
            return View();
        }

        public IActionResult Dashboard()
        {
            ViewBag.Name = TempData["Name"];
            return View();
        }

        public IActionResult Logout()
        {
            TempData.Clear();
            return RedirectToAction("Login");
        }
    }
}