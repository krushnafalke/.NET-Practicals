using Microsoft.AspNetCore.Mvc;
using ShopEase.Models;

namespace ShopEase.Controllers
{
    public class CategoryController : Controller
    {
        public static List<Category> categories = new List<Category>();

        public IActionResult Index()
        {
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (categories.Any(c => c.CategoryId == category.CategoryId))
            {
                ViewBag.Error = "Category ID already exists";
                return View();
            }

            categories.Add(category);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Category category = categories.FirstOrDefault(x => x.CategoryId == id);

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            Category c = categories.FirstOrDefault(x => x.CategoryId == category.CategoryId);

            if (c != null)
            {
                c.CategoryName = category.CategoryName;
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Category category = categories.FirstOrDefault(x => x.CategoryId == id);

            if (category != null)
            {
                categories.Remove(category);
            }

            return RedirectToAction("Index");
        }
    }
}