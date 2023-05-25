using System.ComponentModel.DataAnnotations;

namespace TheSmartCafe.Model
{
    public class Owner
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Owner() { }
    }
}
