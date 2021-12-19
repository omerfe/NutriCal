using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriCal.Models
{
    public class UserExercise
    {
        [Key, Column(Order = 0)]
        public int UserId { get; set; }

        [Key, Column(Order = 1)]
        public int ExerciseId { get; set; }
        public virtual User User { get; set; }
        public virtual Exercise Exercise { get; set; }
        public DateTime ExerciseAddedTime { get; set; } = DateTime.Today;
    }
}
