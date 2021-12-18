using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriCal.Models
{
    public class NutriCalDbContext : DbContext
    {
        public NutriCalDbContext() : base("name=NutricalDbContext")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<UserFood> UserFoods { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<UserExercise> UserExercises { get; set; }
    }
}
