using NutriCal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriCal.InitialStrategies
{
    public class DbInitialStrategy : CreateDatabaseIfNotExists<NutriCalDbContext>
    {
        protected override void Seed(NutriCalDbContext context)
        {
            List<FoodCategory> foodCategories = null;
            if (!context.Exercises.Any())
            {
                List<Exercise> exercises = new List<Exercise>()
                {
                   new Exercise()
                   {
                       ExerciseName= "Running",
                       BurnedEnergy = 125.0,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Walking",
                       BurnedEnergy = 71.4,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                       new Exercise()
                   {
                       ExerciseName= "Swimming",
                       BurnedEnergy = 171.5,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Basketball",
                       BurnedEnergy = 125.0,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Cleaning",
                       BurnedEnergy = 28.6,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Cycling",
                       BurnedEnergy = 101.1,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Dancing",
                       BurnedEnergy = 242.9,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Gym",
                       BurnedEnergy = 130.5,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Hunting",
                       BurnedEnergy = 37.5,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Jumping Rope",
                       BurnedEnergy = 278.6,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Volleyball",
                       BurnedEnergy = 107.2,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Billiards",
                       BurnedEnergy = 53.6,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Bowling",
                       BurnedEnergy = 100.0,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Diving",
                       BurnedEnergy = 71.4,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Polo",
                       BurnedEnergy = 250.0,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Soccer",
                       BurnedEnergy = 214.3,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Surfing",
                       BurnedEnergy = 71.4,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Windsurfing",
                       BurnedEnergy = 142.9,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Yoga",
                       BurnedEnergy = 51.2,
                       Duration = 30,
                       ExerciseRole = "A"
                   }

                };
                foreach (Exercise exercise in exercises)
                    context.Exercises.Add(exercise);
            }

            if (!context.FoodCategories.Any())
            {
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
                }};

                foreach (FoodCategory item in foodCategories)
                    context.FoodCategories.Add(item);
            }

            if (!context.Foods.Any())
            {
                List<Food> foods = null;
                foods = new List<Food>()
                {
                    new Food()
                    {
                        FoodName = "Bread",
                        Porsion = Enums.Porsions.Slice,
                        FoodCalories =  265d,
                        FoodRole = "0",
                        FoodImage = "https://cdn-icons-png.flaticon.com/512/1140/1140055.png",
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 1)
                    },
                    new Food()
                    {
                        FoodName = "Cereal",
                        Porsion= Enums.Porsions.Bowl,
                        FoodCalories =  110d,
                        FoodRole = "0",
                        FoodImage = "https://icons.iconarchive.com/icons/google/noto-emoji-food-drink/512/32394-bowl-with-spoon-icon.png",
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 1)
                    },
                    new Food()
                    {
                        FoodName = "Potato (Baked)",
                        Porsion = Enums.Porsions.Piece,
                        FoodCalories = 220d,
                        FoodRole = "0",
                        FoodImage = "https://www.pinclipart.com/picdir/big/324-3247401_potato-icon-clip-art-icone-batata-png-download.png",
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 2)
                    },
                    new Food()
                    {
                        FoodName = "Latte",
                        Porsion = Enums.Porsions.Cup,
                        FoodCalories = 42d,
                        FoodRole = "0",
                        FoodImage = "https://cdn-icons-png.flaticon.com/512/2935/2935307.png",
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 3)
                    },
                    new Food()
                    {
                        FoodName = "Apple",
                        Porsion = Enums.Porsions.Piece,
                        FoodCalories = 95d,
                        FoodRole = "0",
                        FoodImage = "https://cdn-icons-png.flaticon.com/512/740/740922.png",
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 4)
                    },
                    new Food()
                    {
                        FoodName = "Yogurt",
                        Porsion = Enums.Porsions.Bowl,
                        FoodCalories = 154d,
                        FoodRole = "0",
                        FoodImage = "https://cdn-icons-png.flaticon.com/512/2592/2592587.png",
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 5)
                    },
                    new Food()
                    {
                        FoodName = "Beef",
                        Porsion = Enums.Porsions.Grams,
                        FoodCalories = 500d,
                        FoodRole = "0",
                        FoodImage = "https://cdn-icons-png.flaticon.com/512/3143/3143643.png",
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 6)
                    },
                    new Food()
                    {
                        FoodName = "Peanut Butter",
                        Porsion = Enums.Porsions.Tablespoon,
                        FoodCalories = 52d,
                        FoodRole = "0",
                        FoodImage = "https://cdn-icons-png.flaticon.com/512/735/735874.png",
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 7)
                    },
                    new Food()
                    {
                        FoodName = "Egg",
                        Porsion = Enums.Porsions.Piece,
                        FoodCalories = 155d,
                        FoodRole = "0",
                        FoodImage = "https://cdn-icons-png.flaticon.com/512/837/837560.png",
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 8)
                    },
                    new Food()
                    {
                        FoodName = "Mayonnaise",
                        Porsion = Enums.Porsions.Grams,
                        FoodCalories = 680d,
                        FoodRole = "0",
                        FoodImage = "https://cdn-icons-png.flaticon.com/512/457/457833.png",
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 9)
                    },
                    new Food()
                    {
                        FoodName = "Broccoli Soup",
                        Porsion = Enums.Porsions.Bowl,
                        FoodCalories = 206d,
                        FoodRole = "0",
                        FoodImage = "https://cdn-icons-png.flaticon.com/512/454/454570.png",
                        FoodCategory = foodCategories.FirstOrDefault(x=>x.FoodCategoryId == 10)
                    }
                 };
                foreach (Food item in foods)
                    context.Foods.Add(item);
            }

            context.SaveChanges();
        }
    }
}
