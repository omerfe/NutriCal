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
                context.SaveChanges();
            }
        }
    }
}
