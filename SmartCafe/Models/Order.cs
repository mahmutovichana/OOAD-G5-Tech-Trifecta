using System;
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
        public DateTime orderTime { get; set; }
        [ForeignKey("Bartender")]
        public int idBartender { get; set; }
        public Bartender bartender { get; set; }
        [ForeignKey("Guest")]
        public int idGuest { get; set; }
        public Guest guest { get; set; }

        public Order(){}
    }
}
