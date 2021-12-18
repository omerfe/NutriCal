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
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double Calories { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
