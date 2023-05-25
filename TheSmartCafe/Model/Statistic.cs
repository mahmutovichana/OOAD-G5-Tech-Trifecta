using System.ComponentModel.DataAnnotations.Schema;

namespace TheSmartCafe.Model
{
    public class Statistic
    {
        public double totalProfit { get; set; }
        public double dailyProfit { get; set; }
        [ForeignKey("Drink")]
        public Drink mostSoldDrink { get; set; }
        public int noOfEmployees { get; set; }

        public Statistic()
        {
        }
    }
}
