using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheSmartCafe.Model
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

        public DrinkIngredient(){}
    }
}
