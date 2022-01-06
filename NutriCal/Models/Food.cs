using NutriCal.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutriCal.Models
{
    public class Food
    {
        //
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public double FoodCalories { get; set; }
        public int Quantity { get; set; } 
        public Porsions Porsion { get; set; }
        public string FoodImage { get; set; }
        public string FoodRole { get; set; }
        public int? FoodCategoryId { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }

    }
}