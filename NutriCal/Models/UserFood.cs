using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriCal.Models
{
    public class UserFood
    {
        public int UserFoodId { get; set; }
        public string Name { get; set; }
        public double Calorie { get; set; }
        public int? UFCategoryId { get; set; }
        public virtual FoodCategory UFCategory { get; set; }
    }
}
