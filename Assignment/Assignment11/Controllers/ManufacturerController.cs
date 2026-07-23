using Microsoft.AspNetCore.Mvc;
using Assignment11.Models;

namespace Assignment11.Controllers
{
    public class ManufacturerController : Controller
    {
        public IActionResult Details()
        {
            Manufacturer manufacturer = new Manufacturer()
            {
                ManufacturerName = "Tata Motors",
                Country = "India",
                ContactNumber = "9876543xxx",
                EmailAddress = "info@tatamotors.com"
            };

            return View(manufacturer);
        }
    }
}