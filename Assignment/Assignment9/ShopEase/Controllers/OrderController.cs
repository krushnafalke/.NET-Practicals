using Microsoft.AspNetCore.Mvc;
using ShopEase.Models;

namespace ShopEase.Controllers
{
    public class OrderController : Controller
    {
        public static List<Order> orders = new List<Order>();

        public IActionResult Index()
        {
            return View(orders);
        }

        public IActionResult PlaceOrder()
        {
            double total = CartController.cartItems.Sum(x => x.Total);

            double discount = 0;

            if (total >= 1000)
                discount = total * 0.10;

            double gst = (total - discount) * 0.18;

            Order order = new Order();

            order.OrderId = orders.Count + 1;
            order.CustomerName = "Customer";
            order.OrderDate = DateTime.Now;
            order.Total = total;
            order.Discount = discount;
            order.GST = gst;
            order.GrandTotal = total - discount + gst;

            orders.Add(order);

            CartController.cartItems.Clear();

            return RedirectToAction("Index");
        }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(int id)
        {
            Order order = orders.FirstOrDefault(x => x.OrderId == id);

            return View(order);
        }

        public IActionResult Delete(int id)
        {
            Order order = orders.FirstOrDefault(x => x.OrderId == id);

            if(order!=null)
            {
                orders.Remove(order);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Invoice(int id)
        {
            Order order = orders.FirstOrDefault(x => x.OrderId == id);

            return View(order);
        }
    }
}