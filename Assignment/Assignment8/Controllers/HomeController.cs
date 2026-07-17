using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment8.Models;

namespace Assignment8.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
           
            return View();
        }

    


    }
}
