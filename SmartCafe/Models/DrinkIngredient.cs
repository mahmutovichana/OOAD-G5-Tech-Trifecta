using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SmartCafe.Models
{
    public class DrinkIngredient
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("Drink")]
        public int idDrink { get; set; }
        public Drink drink { get; set; }
        [ForeignKey("Ingredient")]
        public int idIngredient { get; set; }
        public Ingredient ingredient { get; set; }

        public DrinkIngredient() { }
    }
}
