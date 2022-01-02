using NutriCal.InitialStrategies;
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
        public NutriCalDbContext() : base("name=NutriCalDbContext")
        {
            Database.SetInitializer(new DbInitialStrategy());
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>().HasKey(q => q.UserId);
        //    modelBuilder.Entity<Exercise>().HasKey(q => q.ExerciseId);
        //    modelBuilder.Entity<UserExercise>().HasKey(q => new
        //    {
        //        q.ExerciseId, q.UserId
        //    });

        //    modelBuilder.Entity<UserExercise>()
        //        .HasRequired(x=>x.)
        //}
        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<UserExercise> UserExercises { get; set; }
    }
}
