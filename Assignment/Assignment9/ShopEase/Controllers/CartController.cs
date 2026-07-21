using Microsoft.AspNetCore.Mvc;
using ShopEase.Models;

namespace ShopEase.Controllers
{
    public class CartController : Controller
    {
        public static List<Cart> cartItems = new List<Cart>();

        public IActionResult Index()
        {
            return View(cartItems);
        }

        public IActionResult Add(int id)
        {
            Product product = ProductController.products.FirstOrDefault(x => x.ProductId == id);

            if (product != null)
            {
                Cart item = cartItems.FirstOrDefault(x => x.ProductId == id);

                if (item == null)
                {
                    cartItems.Add(new Cart
                    {
                        ProductId = product.ProductId,
                        ProductName = product.Name,
                        Price = product.Price,
                        Quantity = 1
                    });
                }
                else
                {
                    item.Quantity++;
                }
            }

            return RedirectToAction("Index");
        }

        public IActionResult Increase(int id)
        {
            Cart item = cartItems.FirstOrDefault(x => x.ProductId == id);

            if(item!=null)
            {
                item.Quantity++;
            }

            return RedirectToAction("Index");
        }

        public IActionResult Decrease(int id)
        {
            Cart item = cartItems.FirstOrDefault(x => x.ProductId == id);

            if(item!=null)
            {
                item.Quantity--;

                if(item.Quantity<=0)
                {
                    cartItems.Remove(item);
                }
            }

            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            Cart item = cartItems.FirstOrDefault(x => x.ProductId == id);

            if(item!=null)
            {
                cartItems.Remove(item);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Clear()
        {
            cartItems.Clear();

            return RedirectToAction("Index");
        }

        public IActionResult ApplyCoupon(string coupon)
        {
            double total = cartItems.Sum(x => x.Total);

            double discount = 0;

            if(coupon=="SAVE10")
            {
                discount = total * 0.10;
            }

            ViewBag.Total = total;
            ViewBag.Discount = discount;
            ViewBag.Final = total-discount;

            return View("Summary");
        }

        public IActionResult Checkout()
        {
            return RedirectToAction("Index","Payment");
        }
    }
}