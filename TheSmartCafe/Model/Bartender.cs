using System.ComponentModel.DataAnnotations;

namespace TheSmartCafe.Model
{
    public class Bartender
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public Bartender() { }
    }
}
