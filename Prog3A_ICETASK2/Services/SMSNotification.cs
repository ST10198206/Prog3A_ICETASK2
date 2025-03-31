using Prog3A_ICETASK2.Models;

namespace Prog3A_ICETASK2.Services
{
    public class SMSNotification : IOrderNotification
    {
        public void Notify(Order order)
        {
            // Mock SMS notification (replace with actual SMS sending logic later)
            Console.WriteLine($"SMS notification sent to {order.CustomerEmail}.");
        }
    }
}
