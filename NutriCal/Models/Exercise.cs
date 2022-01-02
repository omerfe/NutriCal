using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriCal.Models
{
    public class Exercise
    {
        [Key]
        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public double BurnedEnergy { get; set; }
        public int Duration { get; set; }
        public string ExerciseRole { get; set; }
        public virtual ICollection<UserExercise> UserExercises { get; set; }
    }
}
