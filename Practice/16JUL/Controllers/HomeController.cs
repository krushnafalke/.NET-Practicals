using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _16JUL.Models;



namespace _16JUL.Controllers
{

    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
               new Student
               {
                   Id = 101, Name = "abc", Age = 20, Course = "Dot Net Framework", Qualification = "BE", Marks= 70
               },
                new Student
               {
                   Id = 102, Name = "xyz", Age = 19, Course = "Java Framework", Qualification = "BCom", Marks= 80
               },
                new Student
               {
                   Id = 103, Name = "pyq", Age = 21, Course = "Frontend Framework", Qualification = "BTech", Marks= 85
               },
                new Student
               {
                   Id = 104, Name = "mno", Age = 20, Course = "Dot Net Framework", Qualification = "BA", Marks= 90
               },
            };
            return View(students);
        }

    
    }
}
