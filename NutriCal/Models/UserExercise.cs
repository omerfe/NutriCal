using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriCal.Models
{
    public class UserExercise
    {
        public int UserExerciseId { get; set; }
        public string Name { get; set; }
        public double BurntCalorie { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
