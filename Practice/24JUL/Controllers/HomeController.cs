using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _24JUL.Models;
using _24JJUL.Models;

namespace _24JUL.Controllers;

public class HomeController : Controller
{


    public IActionResult Index()
    {
        return View();

    }

    [HttpPost] 

    public ActionResult Index(Student student)
    {
        if (ModelState.IsValid)
        {
            if(student.Username=="admin"&&student.Password == "12345")
            {
                HttpContext.Session.SetString("User",student.Username);
                return RedirectToAction("Dashboard");
            }
            ViewBag.Error = "Invalid username or password";
        }
        return View(student);
    }
    public ActionResult Dashboard()
    {
        var user = HttpContext.Session.GetString("User");
        if (String.IsNullOrEmpty(user))
        {
            return RedirectToAction("Index");
        }
        ViewBag.User = user;
        return View();
    }

    public ActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

}
