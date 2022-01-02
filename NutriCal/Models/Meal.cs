using System;
using System.Collections.Generic;

namespace NutriCal.Models
{
    public class Meal
    {
        public int MealId { get; set; }
        public string MealName { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public double TotalCalories { get; set; }
        public virtual List<Food> Foods { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}