using NutriCal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriCal
{
    public partial class MealsForm : Form
    {
        private readonly NutriCalDbContext db;
        private readonly User user;

        public MealsForm( User user,NutriCalDbContext db)
        {
            InitializeComponent();
            this.db = db;
            this.user = user;
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now.Date;

            Meal selectedMeal = db.Meals.FirstOrDefault(x => x.MealName == "Breakfast" &&  DbFunctions.TruncateTime(x.Date) == dt && x.Users.Any(u => u.UserId == user.UserId));

            if (selectedMeal == null) // kahvaltı yok. yeni oluturmamız lazım.
            {
                selectedMeal = new Meal()
                {
                    MealName = "Breakfast"
                };
                user.Meals.Add(selectedMeal);
                db.SaveChanges();
            }
      

            FoodsForm foodsForm = new FoodsForm(db,selectedMeal, pboBreakfast.Image);
            foodsForm.ShowDialog();
        }

        private void btnMorningSnack_Click(object sender, EventArgs e)
        {
            //FoodsForm foodsForm = new FoodsForm(btnMorningSnack.Text, pboMorningSnack.Image);
            //foodsForm.ShowDialog();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            //FoodsForm foodsForm = new FoodsForm(btnLunch.Text, pboLunch.Image);
            //foodsForm.ShowDialog();
        }

        private void btnAfternoonSnack_Click(object sender, EventArgs e)
        {
            //FoodsForm foodsForm = new FoodsForm(btnAfternoonSnack.Text, pboAfternoonSnack.Image);
            //foodsForm.ShowDialog();
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            //FoodsForm foodsForm = new FoodsForm(btnDinner.Text, pboDinner.Image);
            //foodsForm.ShowDialog();
        }
    }
}
