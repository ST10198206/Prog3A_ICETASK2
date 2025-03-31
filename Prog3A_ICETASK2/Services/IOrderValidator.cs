using Prog3A_ICETASK2.Models;

namespace Prog3A_ICETASK2.Services
{
    public interface IOrderValidator
    {
        bool IsValid(Order order);
    }

}
