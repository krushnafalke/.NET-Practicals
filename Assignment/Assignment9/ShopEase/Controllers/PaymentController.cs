using Microsoft.AspNetCore.Mvc;
using ShopEase.Models;

namespace ShopEase.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string paymentMode)
        {
            ViewBag.Mode = paymentMode;
            ViewBag.Status = "Payment Successful";

            return View();
        }
    }
}