using Microsoft.AspNetCore.Mvc;
using resturant_di.Services;

namespace resturant_di.Controllers
{
    public class OrderController : Controller
    {

        private readonly IReceiptPrinter _printer;

        public OrderController(IReceiptPrinter printer)
        {
            _printer = printer;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PlaceOrder(string dish)
        {
            // Imagine order goes to database here
            string orderDetails = $"Dish: {dish}, Date: {DateTime.Now}";

            // Print receipt via DI
            _printer.Print(orderDetails);

            ViewBag.Message = "Order placed successfully!";
            return View("Index");
        }
    }
}
