using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace SmartCafe.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }
        public bool done { get; set; }
        public int tableNumber { get; set; }
        public DateTime orderTime { get; set; }


        [ForeignKey("Guest")]
        public int idGuest { get; set; }
        public Guest Guest { get; set; }

        public Order() { }
    }
}
