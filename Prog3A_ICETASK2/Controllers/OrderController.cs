using Microsoft.AspNetCore.Mvc;
using Prog3A_ICETASK2.Models;
using Prog3A_ICETASK2.Services;

namespace Prog3A_ICETASK2.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(string customerEmail, int[] productIds)
        {
            // Mock product retrieval (replace with actual product retrieval later)
            var products = new List<Product>();
            foreach (var productId in productIds)
            {
                products.Add(new Product { Id = productId, Name = $"Product {productId}", Price = 10.0m });
            }

            var order = new Order
            {
                Id = new Random().Next(1, 100),
                CustomerEmail = customerEmail,
                Products = products
            };

            _orderService.PlaceOrder(order);

            return Content("Order created successfully!");
        }
    }
}
