using Prog3A_ICETASK2.Models;

namespace Prog3A_ICETASK2.Services
{
    public class OrderService
    {
        private readonly IOrderProcessor _orderProcessor;
        private readonly IOrderValidator _orderValidator;
        private readonly IEnumerable<IOrderNotification> _orderNotifications;

        public OrderService(IOrderProcessor orderProcessor, IOrderValidator orderValidator, IEnumerable<IOrderNotification> orderNotifications)
        {
            _orderProcessor = orderProcessor;
            _orderValidator = orderValidator;
            _orderNotifications = orderNotifications;
        }

        public void PlaceOrder(Order order)
        {
            if (_orderValidator.IsValid(order))
            {
                _orderProcessor.ProcessOrder(order);
                foreach (var notification in _orderNotifications)
                {
                    notification.Notify(order);
                }
            }
        }
    }
}
