using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriCal.Models
{
    public class Meal
    {
        public int MealId { get; set; }
        public string MealName { get; set; }
        public DateTime Date { get; set; }
        public double TotalCalories { get; set; }
        
        public int? UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}
