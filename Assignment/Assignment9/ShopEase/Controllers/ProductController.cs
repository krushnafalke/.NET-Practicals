using Microsoft.AspNetCore.Mvc;
using ShopEase.Models;

namespace ShopEase.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> products = new List<Product>();

        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (products.Any(p => p.ProductId == product.ProductId))
            {
                ViewBag.Error = "Product ID already exists";
                return View();
            }

            products.Add(product);

            return RedirectToAction("Index");
        }

        public IActionResult Search(int id)
        {
            Product product = products.FirstOrDefault(x => x.ProductId == id);

            return View(product);
        }

        public IActionResult Edit(int id)
        {
            Product product = products.FirstOrDefault(x => x.ProductId == id);

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            Product p = products.FirstOrDefault(x => x.ProductId == product.ProductId);

            if (p != null)
            {
                p.Name = product.Name;
                p.Category = product.Category;
                p.Description = product.Description;
                p.Brand = product.Brand;
                p.Price = product.Price;
                p.Quantity = product.Quantity;
                p.Discount = product.Discount;
                p.Rating = product.Rating;
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Product product = products.FirstOrDefault(x => x.ProductId == id);

            if(product!=null)
            {
                products.Remove(product);
            }

            return RedirectToAction("Index");
        }
    }
}