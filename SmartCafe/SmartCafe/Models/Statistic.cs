using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheSmartCafe.Model
{
    public class Statistic
    {
        [Key]
        public int id { get; set; } 
        public double totalProfit { get; set; }
        public double dailyProfit { get; set; }
        [ForeignKey("Drink")]
        public int idDrink { get; set; }
        public Drink mostSoldDrink { get; set; }
        public int noOfEmployees { get; set; }

        public Statistic(){}
    }
}
