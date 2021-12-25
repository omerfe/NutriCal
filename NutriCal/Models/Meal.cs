using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriCal.Models
{
    public class Meal
    {
        public Meal()
        {
            //Users = new List<User>();
        }
        public int MealId { get; set; }
        public string MealName { get; set; }
        public DateTime Date { get; set; }
        public double TotalCalories { get; set; }
        public virtual List<Food> Foods { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}