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
                       BurnedEnergy = 91.7,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Walking",
                       BurnedEnergy = 71.5,
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
                       BurnedEnergy = 71.5,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Cleaning",
                       BurnedEnergy = 71.5,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Cycling",
                       BurnedEnergy = 71.5,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Dancing",
                       BurnedEnergy = 71.5,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Gym",
                       BurnedEnergy = 71.5,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Hunting",
                       BurnedEnergy = 71.5,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Jumping Rope",
                       BurnedEnergy = 71.5,
                       Duration = 30,
                       ExerciseRole = "A"
                   },
                     new Exercise()
                   {
                       ExerciseName= "Volleyball",
                       BurnedEnergy = 71.5,
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
