using Prog3A_ICETASK2.Models;

namespace Prog3A_ICETASK2.Services
{
    public class OrderProcessor : IOrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            // Mock processing logic (replace with actual logic later)
            Console.WriteLine($"Order {order.Id} processed for {order.CustomerEmail}.");
            foreach (var product in order.Products)
            {
                Console.WriteLine($" - {product.Name}");
            }
        }
    }
}
