using Microsoft.AspNetCore.Mvc;
using Assignment12.Models;
using Microsoft.AspNetCore.Http;

namespace Assignment12.Controllers
{
    public class StationeryController : Controller
    {
        static List<Stationery> stationeryList = new List<Stationery>();

       [HttpGet]
        public IActionResult Stationery()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("User")))
            {
                return RedirectToAction("Login", "Home");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Stationery(Stationery stationery)
        {
            if (ModelState.IsValid)
            {
                stationeryList.Add(stationery);

                return Content(
                     $"Item Name : {stationery.ItemName} , " +$"Brand : {stationery.Category} , " +$"Price : {stationery.Price} , " +$"Quantity : {stationery.Stock}"
                );
            }

            return View(stationery);
        }
    }
}