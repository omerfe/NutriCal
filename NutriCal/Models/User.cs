using NutriCal.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriCal.Models
{
    public class User
    {
        public User()
        {
            switch (Gender)
            {
                case Genders.NotSpecified:
                    RecomendedCalorie = 0;
                    break;
                case Genders.Female:
                    RecomendedCalorie = 10 * Weight + (6.25 * Height) - (5 * (DateTime.Now.Year - BirthDate.Year)) - 161;
                    break;
                case Genders.Male:
                    RecomendedCalorie = 10 * Weight + (6.25 * Height) - (5 * (DateTime.Now.Year - BirthDate.Year)) + 5;
                    break;
            }

        }
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public DateTime BirthDate { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public Genders Gender { get; set; }
        public double RecomendedCalorie { get; set; }
        public virtual UserLogin UserLogin { get; set; }
        public virtual ICollection<UserExercise> UserExercises { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
    }
}
