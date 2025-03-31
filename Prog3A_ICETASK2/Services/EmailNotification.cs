using Prog3A_ICETASK2.Models;

namespace Prog3A_ICETASK2.Services
{
    public class EmailNotification : IOrderNotification
    {
        public void Notify(Order order)
        {
            // Mock email notification (replace with actual email sending logic later)
            Console.WriteLine($"Email notification sent to {order.CustomerEmail}.");
        }
    }
}
