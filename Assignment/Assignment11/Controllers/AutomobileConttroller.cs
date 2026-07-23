using Microsoft.AspNetCore.Mvc;
using Assignment11.Models;

namespace Assignment11.Controllers
{
    public class AutomobileController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Automobile automobile)
        {
            if (ModelState.IsValid)
            {
                return View("Success", automobile);
            }

            return View(automobile);
        }
    }
}