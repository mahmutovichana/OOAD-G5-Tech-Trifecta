using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SmartCafe.Models
{
    public class OrderItem
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("Drink")]
        public int idDrink { get; set; }
        public Drink drink { get; set; }
        [ForeignKey("Order")]
        public int idOrder { get; set; }
        public Order order { get; set; }
        public double price { get; set; }
        public OrderItem() { }
    }
}
