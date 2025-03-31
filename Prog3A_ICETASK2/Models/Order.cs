namespace Prog3A_ICETASK2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public string CustomerEmail { get; set; }
    }
}
