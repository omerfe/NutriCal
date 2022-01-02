namespace NutriCal.Migrations
{
    using NutriCal.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NutriCal.Models.NutriCalDbContext>
    {
        NutriCalDbContext db = new NutriCalDbContext();
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "NutriCal.Models.NutriCalDbContext";
        }

        protected override void Seed(NutriCal.Models.NutriCalDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            
                List<FoodCategory> foodCategories = null;
                List<Food> foods = null;

                foodCategories = new List<FoodCategory>
                {
                new FoodCategory
                {
                    CategoryName = "Grain Products",
                    FoodCategoryId = 1
                },
                new FoodCategory
                {
                    CategoryName = "Vegetables",
                    FoodCategoryId = 2
                },
                new FoodCategory
                {
                    CategoryName = "Beverages",
                    FoodCategoryId = 3
                },
                new FoodCategory
                {
                    CategoryName = "Fruits",
                    FoodCategoryId = 4
                },
                new FoodCategory
                {
                    CategoryName = "Dairy Products",
                    FoodCategoryId = 5
                },
                new FoodCategory
                {
                    CategoryName = "Meats",
                    FoodCategoryId = 6
                },
                new FoodCategory
                {
                    CategoryName = "Desserts & Sweets",
                    FoodCategoryId = 7
                },
                new FoodCategory
                {
                    CategoryName = "Eggs & Nuts & Seed",
                    FoodCategoryId = 8
                },
                new FoodCategory
                {
                    CategoryName = "Fats & Oils",
                    FoodCategoryId = 9
                },
                new FoodCategory
                {
                    CategoryName = "Other",
                    FoodCategoryId = 10
                }
                 };
                foreach (FoodCategory item in foodCategories)
                {
                    db.FoodCategories.Add(item);
                }

                foods = new List<Food>()
                {
                    new Food()
                    {
                        FoodName = "Bread",
                        Porsion = Enums.Porsions.Slice,
                        FoodCalories =  265d,
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 1)
                    },
                    new Food()
                    {
                        FoodName = "Cereal",
                        Porsion= Enums.Porsions.Bowl,
                        FoodCalories =  110d,
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 1)
                    },
                    new Food()
                    {
                        FoodName = "Potato (Baked)",
                        Porsion = Enums.Porsions.Piece,
                        FoodCalories = 220d,
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 2)
                    },
                    new Food()
                    {
                        FoodName = "Latte",
                        Porsion = Enums.Porsions.Cup,
                        FoodCalories = 42d,
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 3)
                    },
                    new Food()
                    {
                        FoodName = "Apple",
                        Porsion = Enums.Porsions.Piece,
                        FoodCalories = 95d,
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 4)
                    },
                    new Food()
                    {
                        FoodName = "Yogurt",
                        Porsion = Enums.Porsions.Bowl,
                        FoodCalories = 154d,
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 5)
                    },
                    new Food()
                    {
                        FoodName = "Beef",
                        Porsion = Enums.Porsions.Grams,
                        FoodCalories = 500d,
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 6)
                    },
                    new Food()
                    {
                        FoodName = "Peanut Butter",
                        Porsion = Enums.Porsions.Tablespoon,
                        FoodCalories = 52d,
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 7)
                    },
                    new Food()
                    {
                        FoodName = "Egg",
                        Porsion = Enums.Porsions.Piece,
                        FoodCalories = 155d,
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 8)
                    },
                    new Food()
                    {
                        FoodName = "Mayonnaise",
                        Porsion = Enums.Porsions.Grams,
                        FoodCalories = 680d,
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 9)
                    },
                    new Food()
                    {
                        FoodName = "Broccoli Soup",
                        Porsion = Enums.Porsions.Bowl,
                        FoodCalories = 206d,
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 10)
                    }
                 };
                foreach (Food item in foods)
                {
                    db.Foods.Add(item);
                }
                db.SaveChanges();
        }
    }
}
