using System.Diagnostics;
using _21Jul.Models;
using Microsoft.AspNetCore.Mvc;



namespace _21JUL.Controllers;

public class HomeController : Controller
{
    
    public ActionResult Register()
    {
        return View();
    }

    [HttpPost]

    public ActionResult Register(Student student)
    {
        if (ModelState.IsValid)
        {
            TempData["StudentName"] = student.name;
            return RedirectToAction("Schedule");
        }
        return View(student);
    }
}
