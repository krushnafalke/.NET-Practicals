using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment8.Models;

namespace Assignment8.Controllers
{
    public class EmployeeController : Controller
    {


        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>()
            {
            new Employee
            {
                Employee_Id = 101, Name = "Krushna", Department = "HR", Salary = 1000000, Email = "krushna@gmail.com"  
            },
            new Employee
            {
                Employee_Id = 102, Name = "Arpita", Department = "Management", Salary = 150000, Email = "arpita@gmail.com"  
            },
            new Employee
            {
                Employee_Id = 103, Name = "Dhanashri", Department = "Accounting", Salary = 120000, Email = "dhanashri@gmail.com"  
            }
            };
            return View(employees);
        }

    


    }
}