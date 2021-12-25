namespace NutriCal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exercises",
                c => new
                    {
                        ExerciseId = c.Int(nullable: false, identity: true),
                        ExerciseName = c.String(),
                        BurnedEnergy = c.Double(nullable: false),
                        Duration = c.Int(nullable: false),
                        ExerciseRole = c.String(),
                    })
                .PrimaryKey(t => t.ExerciseId);
            
            CreateTable(
                "dbo.UserExercises",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        ExerciseId = c.Int(nullable: false),
                        ExerciseAddedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.ExerciseId })
                .ForeignKey("dbo.Exercises", t => t.ExerciseId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ExerciseId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserSurname = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Weight = c.Double(nullable: false),
                        Height = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        MealId = c.Int(nullable: false, identity: true),
                        MealName = c.String(),
                        Date = c.DateTime(nullable: false),
                        TotalCalories = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.MealId);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        FoodId = c.Int(nullable: false, identity: true),
                        FoodName = c.String(),
                        FoodCalories = c.Double(nullable: false),
                        Porsion = c.Int(nullable: false),
                        FoodImage = c.String(),
                        FoodCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.FoodId)
                .ForeignKey("dbo.FoodCategories", t => t.FoodCategoryId)
                .Index(t => t.FoodCategoryId);
            
            CreateTable(
                "dbo.FoodCategories",
                c => new
                    {
                        FoodCategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.FoodCategoryId);
            
            CreateTable(
                "dbo.UserLogins",
                c => new
                    {
                        UserLoginId = c.Int(nullable: false),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserLoginId)
                .ForeignKey("dbo.Users", t => t.UserLoginId)
                .Index(t => t.UserLoginId);
            
            CreateTable(
                "dbo.FoodMeals",
                c => new
                    {
                        Food_FoodId = c.Int(nullable: false),
                        Meal_MealId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Food_FoodId, t.Meal_MealId })
                .ForeignKey("dbo.Foods", t => t.Food_FoodId, cascadeDelete: true)
                .ForeignKey("dbo.Meals", t => t.Meal_MealId, cascadeDelete: true)
                .Index(t => t.Food_FoodId)
                .Index(t => t.Meal_MealId);
            
            CreateTable(
                "dbo.MealUsers",
                c => new
                    {
                        Meal_MealId = c.Int(nullable: false),
                        User_UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Meal_MealId, t.User_UserId })
                .ForeignKey("dbo.Meals", t => t.Meal_MealId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserId, cascadeDelete: true)
                .Index(t => t.Meal_MealId)
                .Index(t => t.User_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserLogins", "UserLoginId", "dbo.Users");
            DropForeignKey("dbo.UserExercises", "UserId", "dbo.Users");
            DropForeignKey("dbo.MealUsers", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.MealUsers", "Meal_MealId", "dbo.Meals");
            DropForeignKey("dbo.FoodMeals", "Meal_MealId", "dbo.Meals");
            DropForeignKey("dbo.FoodMeals", "Food_FoodId", "dbo.Foods");
            DropForeignKey("dbo.Foods", "FoodCategoryId", "dbo.FoodCategories");
            DropForeignKey("dbo.UserExercises", "ExerciseId", "dbo.Exercises");
            DropIndex("dbo.MealUsers", new[] { "User_UserId" });
            DropIndex("dbo.MealUsers", new[] { "Meal_MealId" });
            DropIndex("dbo.FoodMeals", new[] { "Meal_MealId" });
            DropIndex("dbo.FoodMeals", new[] { "Food_FoodId" });
            DropIndex("dbo.UserLogins", new[] { "UserLoginId" });
            DropIndex("dbo.Foods", new[] { "FoodCategoryId" });
            DropIndex("dbo.UserExercises", new[] { "ExerciseId" });
            DropIndex("dbo.UserExercises", new[] { "UserId" });
            DropTable("dbo.MealUsers");
            DropTable("dbo.FoodMeals");
            DropTable("dbo.UserLogins");
            DropTable("dbo.FoodCategories");
            DropTable("dbo.Foods");
            DropTable("dbo.Meals");
            DropTable("dbo.Users");
            DropTable("dbo.UserExercises");
            DropTable("dbo.Exercises");
        }
    }
}
