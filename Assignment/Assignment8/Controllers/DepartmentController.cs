using Microsoft.AspNetCore.Mvc;
using Assignment8.Models;

namespace Assignment8.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>()
            {
                new Department
                {
                    Department_Name = "IT",
                    Department_Head = "Rakesh",
                    Head_Contact = "9876543210",
                    Head_Email = "rakesh@gmail.com"
                },

                new Department
                {
                    Department_Name = "HR",
                    Department_Head = "Sneha",
                    Head_Contact = "9876543211",
                    Head_Email = "sneha@gmail.com"
                },

                new Department
                {
                    Department_Name = "Sales",
                    Department_Head = "Vikas",
                    Head_Contact = "9876543212",
                    Head_Email = "vikas@gmail.com"
                }
            };

            return View(departments);
        }
    }
}