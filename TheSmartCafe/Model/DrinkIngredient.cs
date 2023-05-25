using System.ComponentModel.DataAnnotations.Schema;

namespace TheSmartCafe.Model
{
    public class DrinkIngredient
    {
        [ForeignKey("Drink")]
        public Drink drink { get; set; }
        [ForeignKey("Ingredient")]
        public Ingredient ingredient { get; set; }

        public DrinkIngredient(){}
    }
}
