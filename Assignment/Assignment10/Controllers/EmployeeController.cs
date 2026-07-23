using Microsoft.AspNetCore.Mvc;
using Assignment10.Models;

namespace Assignment10.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Employee emp)
        {
            if (ModelState.IsValid)
            {
                return View("Success", emp);
            }

            return View(emp);
        }

        public IActionResult Department()
        {
            Department dept = new Department()
            {
                DepartmentName = "IT",
                DepartmentHead = "Krushna Falke",
                HeadContactNumber = "8999887119",
                HeadEmail = "krushna@company.com"
            };

            return View(dept);
        }
    }
}