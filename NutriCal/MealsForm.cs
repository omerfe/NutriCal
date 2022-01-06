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
        Meal selectedMeal;

        public MealsForm( User user,NutriCalDbContext db)
        {
            InitializeComponent();
            this.db = db;
            this.user = user;
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Date;

            selectedMeal = db.Meals.FirstOrDefault(x => x.MealName == "Breakfast" &&  DbFunctions.TruncateTime(x.Date) == dt && x.Users.Any(u => u.UserId == user.UserId));

            if (selectedMeal == null) 
            {
                selectedMeal = new Meal()
                {
                    MealName = "Breakfast"
                };
                user.Meals.Add(selectedMeal);
                db.SaveChanges();
            }

            FoodsForm foodsForm = new FoodsForm(db,selectedMeal, pboBreakfast.Image, user);
            foodsForm.ShowDialog();
        }


        private void btnMorningSnack_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Date;

            selectedMeal = db.Meals.FirstOrDefault(x => x.MealName == "Morning Snack" && DbFunctions.TruncateTime(x.Date) == dt && x.Users.Any(u => u.UserId == user.UserId));

            if (selectedMeal == null) 
            {
                selectedMeal = new Meal()
                {
                    MealName = "Morning Snack"
                };
                user.Meals.Add(selectedMeal);
                db.SaveChanges();
            }

            FoodsForm foodsForm = new FoodsForm(db, selectedMeal, pboMorningSnack.Image, user);
            foodsForm.ShowDialog();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Date;

            selectedMeal = db.Meals.FirstOrDefault(x => x.MealName == "Lunch" && DbFunctions.TruncateTime(x.Date) == dt && x.Users.Any(u => u.UserId == user.UserId));

            if (selectedMeal == null) 
            {
                selectedMeal = new Meal()
                {
                    MealName = "Lunch"
                };
                user.Meals.Add(selectedMeal);
                db.SaveChanges();
            }

            FoodsForm foodsForm = new FoodsForm(db, selectedMeal, pboLunch.Image, user);
            foodsForm.ShowDialog();
        }

        private void btnAfternoonSnack_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Date;

            selectedMeal = db.Meals.FirstOrDefault(x => x.MealName == "Afternoon Snack" && DbFunctions.TruncateTime(x.Date) == dt && x.Users.Any(u => u.UserId == user.UserId));

            if (selectedMeal == null) 
            {
                selectedMeal = new Meal()
                {
                    MealName = "Afternoon Snack"
                };
                user.Meals.Add(selectedMeal);
                db.SaveChanges();
            }

            FoodsForm foodsForm = new FoodsForm(db, selectedMeal, pboAfternoonSnack.Image, user);
            foodsForm.ShowDialog();
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Date;

            selectedMeal = db.Meals.FirstOrDefault(x => x.MealName == "Dinner" && DbFunctions.TruncateTime(x.Date) == dt && x.Users.Any(u => u.UserId == user.UserId));

            if (selectedMeal == null) 
            {
                selectedMeal = new Meal()
                {
                    MealName = "Dinner"
                };
                user.Meals.Add(selectedMeal);
                db.SaveChanges();
            }

            FoodsForm foodsForm = new FoodsForm(db, selectedMeal, pboDinner.Image, user);
            foodsForm.ShowDialog();
        }
    }
}
