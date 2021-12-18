using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriCal.Models
{
    public class UserLogin
    {
        [ForeignKey("User")]
        public int UserLoginId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual User User { get; set; }
    }
}
