using System.ComponentModel.DataAnnotations;

namespace TheSmartCafe.Model
{
    public class Guest
    {
        [Key]
        public int id { get; set; }
        public int tableNumber {  get; set; }

        public Guest() {    }
    }
}
