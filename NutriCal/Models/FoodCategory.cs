using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriCal.Models
{
    public class FoodCategory
    {
        public int FoodCategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
