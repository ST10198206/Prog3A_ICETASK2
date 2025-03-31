using Prog3A_ICETASK2.Models;

namespace Prog3A_ICETASK2.Services
{
    public class OrderValidator : IOrderValidator
    {
        public bool IsValid(Order order)
        {
            // Mock validation logic (replace with actual logic later)
            if (order == null || order.Products == null || order.Products.Count == 0 || string.IsNullOrEmpty(order.CustomerEmail))
            {
                Console.WriteLine("Order validation failed.");
                return false;
            }
            Console.WriteLine("Order validation successful.");
            return true;
        }
    }
}
