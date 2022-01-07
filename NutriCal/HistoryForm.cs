using MassTransit.Util;
using NutriCal.Enums;
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
    public partial class HistoryForm : Form
    {
        private readonly NutriCalDbContext db;
        private readonly User user;
        List<string> mealNames;
        public HistoryForm(NutriCalDbContext db, User user)
        {
            InitializeComponent();
            this.db = db;
            this.user = user;
            mealNames = new List<string>()
            {
                "Breakfast", "Morning Snack","Lunch","Afternoon Snack","Dinner"
            };
            DailyCaloriesByMeals();
        }
        private void DailyCaloriesByMeals()
        {
            var dt = DateTime.Now.Date;
            gbDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lblUser.Text = $"{user.UserName} {user.UserSurname}'s Daily Consumption";

            double totalBreakfastCal = 0, totalMorningSnackCal = 0, totalLunchCal = 0, totalAfternoonSnackCal = 0, totalDinnerCal = 0;
            var userBreakfast = user.Meals.FirstOrDefault(x => x.MealName == "Breakfast" && x.Date.Date == dt);
            if (userBreakfast != null)
            {
                totalBreakfastCal = userBreakfast.Foods.Sum(x => x.FoodCalories);
                lblBreakfast.Text = $"{totalBreakfastCal} kcal";
            }

            var userMorningSnack = user.Meals.FirstOrDefault(x => x.MealName == "Morning Snack" && x.Date.Date == dt);
            if (userMorningSnack != null)
            {
                totalMorningSnackCal = userMorningSnack.Foods.Sum(x => x.FoodCalories);
                lblMorningSnack.Text = $"{totalMorningSnackCal} kcal";
            }

            var userLunch = user.Meals.FirstOrDefault(x => x.MealName == "Lunch" && x.Date.Date == dt);
            if (userLunch != null)
            {
                totalLunchCal = userLunch.Foods.Sum(x => x.FoodCalories);
                lblLunch.Text = $"{totalLunchCal} kcal";
            }

            var userAfternoonSnack = user.Meals.FirstOrDefault(x => x.MealName == "Afternoon Snack" && x.Date.Date == dt);
            if (userAfternoonSnack != null)
            {
                totalAfternoonSnackCal = userAfternoonSnack.Foods.Sum(x => x.FoodCalories);
                lblAfternoonSnack.Text = $"{totalAfternoonSnackCal} kcal";
            }

            var userDinner = user.Meals.FirstOrDefault(x => x.MealName == "Dinner" && x.Date.Date == dt);
            if (userDinner != null)
            {
                totalDinnerCal = userDinner.Foods.Sum(x => x.FoodCalories);
                lblDinner.Text = $"{totalDinnerCal} kcal";
            }

            double totalCal = totalBreakfastCal + totalMorningSnackCal + totalLunchCal + totalAfternoonSnackCal + totalDinnerCal;
            lblTotalCalories.Text = $"{totalCal} kcal";
        }
        private void cmbMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Food> foodList = new List<Food>();
            string selectedText = "";
            switch (cmbByMeal.SelectedIndex)
            {
                case 0:
                    selectedText = "Breakfast";
                    break;
                case 1:
                    selectedText = "Morning Snack";
                    break;
                case 2:
                    selectedText = "Lunch";
                    break;
                case 3:
                    selectedText = "Afternoon Snack";
                    break;
                case 4:
                    selectedText = "Dinner";
                    break;
            }

            List<Meal> mealList = db.Meals.Where(x => x.MealName == selectedText).ToList();
            foreach (var meal in mealList)
                foreach (var food in meal.Foods)
                    foodList.Add(food);

            var listbyCat = foodList.GroupBy(x => x.FoodName).Select(y => new
            {
                Name = y.Key,
                Count = y.Sum(p => p.Quantity)
            }).OrderByDescending(z => z.Count).ToList();

            dgvFoods.DataSource = listbyCat;
        }
        private void rbMeal_Click(object sender, EventArgs e)
        {
            FillComboWithMeals();
            cmbByMeal.Enabled = true;
            cmbByCategory.Enabled = false;
        }
        private void FillComboWithMeals()
        {
            cmbByMeal.DataSource = mealNames;
        }
        private void rbCategory_Click(object sender, EventArgs e)
        {
            FillComboWithCategories();
            cmbByCategory.Enabled = true;
            cmbByMeal.Enabled = false;
        }
        private void FillComboWithCategories()
        {
            cmbByCategory.DataSource = db.FoodCategories.ToList();
            cmbByCategory.DisplayMember = "CategoryName";
        }
        private void cmbByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            FoodCategory foodCategory = (FoodCategory)cmbByCategory.SelectedItem;
            List<Food> foodList = db.Foods.Where(x => x.FoodCategory.CategoryName == foodCategory.CategoryName && x.FoodRole != "0").ToList();
            List<Food> finalFoods = new List<Food>();

            for (int i = 0; i < foodList.Count; i++)
            {
                if (!finalFoods.Any(x => x.FoodName == foodList[i].FoodName))
                {
                    finalFoods.Add(foodList[i]);
                }
            }

            dgvFoods.DataSource = finalFoods.Select(x => new
            {
                x.FoodName,
                x.FoodCalories
            }).ToList();
        }
        private void cmbTimeInt_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            switch (cmbTimeInt.SelectedIndex)
            {
                case 0:
                    dt = DateTime.Now.AddDays(-7);
                    break;
                case 1:
                    dt = DateTime.Now.AddMonths(-1);
                    break;
                default:
                    MessageBox.Show("asdasda");
                    break;
            }
            CalculateAveragesForAll("Breakfast", lblTotalBreakfast, dt);
            CalculateAveragesForAll("Morning Snack", lblTotalMSnack, dt);
            CalculateAveragesForAll("Lunch", lblTotalLunch, dt);
            CalculateAveragesForAll("Afternoon Snack", lblTotalASnack, dt);
            CalculateAveragesForAll("Dinner", lblTotalDinner, dt);
            CalculateAveragesForUsers("Breakfast", lblUserBreakfast, dt);
            CalculateAveragesForUsers("Morning Snack", lblUserMSnack, dt);
            CalculateAveragesForUsers("Lunch", lblUserLunch, dt);
            CalculateAveragesForUsers("Afternoon Snack", lblUserASnack, dt);
            CalculateAveragesForUsers("Dinner", lblUserDinner, dt);
        }
        private void CalculateAveragesForAll(string mealName, Label label, DateTime dt)
        {
            List<Meal> mealList = db.Meals.Where(x => x.MealName == mealName && DbFunctions.TruncateTime(x.Date) > dt.Date).ToList();
            double totalCal = mealList.Sum(z => z.TotalCalories);

            if (totalCal > 0)
            {
                int totalMeal = mealList.Count();
                double avg = totalCal / totalMeal;
                label.Text = $"{avg:n2} kcal";
            }
        }
        private void CalculateAveragesForUsers(string mealName, Label label, DateTime dt)
        {
            List<Meal> userMealList = user.Meals.Where(x => x.MealName == mealName && x.Date.Date > dt.Date).ToList();
            double totalCal = userMealList.Sum(z => z.TotalCalories);

            if (totalCal > 0)
            {
                int totalMeal = userMealList.Count();
                double avg = totalCal / totalMeal;
                label.Text = $"{avg:n2} kcal";
            }
=======
            
>>>>>>> 93ea2775903c54b5f2b66d45abad62823fad5dff
        }
    }
}
