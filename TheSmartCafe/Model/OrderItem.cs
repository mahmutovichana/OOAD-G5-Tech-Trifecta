using System.ComponentModel.DataAnnotations.Schema;

namespace TheSmartCafe.Model
{
    public class OrderItem
    {
        [ForeignKey("Drink")]
        public Drink drink { get; set; }
        [ForeignKey("Order")]
        public Order order { get; set; }
        public double price { get; set; }
        public OrderItem() { }
    }
}
