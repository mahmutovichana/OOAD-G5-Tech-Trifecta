using System.ComponentModel.DataAnnotations;

namespace SmartCafe.Models
{
    public class Guest
    {
        [Key]
        public int id { get; set; }
        public int tableNumber { get; set; }

        public Guest() { }
    }
}
