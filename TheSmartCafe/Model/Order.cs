using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheSmartCafe.Model
{
    public class Order
    {
        [Key]
        public int id { get; set; }
        public bool done { get; set; }
        public int tableNumber { get; set; }
        public TimeOnly orderTime { get; set; }
        [ForeignKey("Bartender")]
        public Bartender bartender { get; set; }
        [ForeignKey("Guest")]
        public Guest guest { get; set; }

        public Order()
        {
        }
    }
}
