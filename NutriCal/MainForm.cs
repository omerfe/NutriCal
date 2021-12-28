using NutriCal.Models;
using NutriCal.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NutriCal
{
    public partial class MainForm : Form
    {
        NutriCalDbContext db = new NutriCalDbContext();
        User user;
        public MainForm()
        {
            user = db.Users.ToList()[0];
            //TODO: giriş yapan user
            InitializeComponent();
            SetWidthDataGrid();
            GetAllSummary();
            SortHiddenTimesOnDataGrid();
        }
        private void SortHiddenTimesOnDataGrid() => dgvSummary.Sort(dataGridViewColumn: dgvSummary.Columns[dgvSummary.ColumnCount - 1], direction: ListSortDirection.Descending);
        private void GetAllSummary()
        {
            dgvSummary.Rows.Clear();
            var dt = DateTime.Now.Date;
            
            var deneme = db.Exercises.ToList();
            var exerciseList = db.UserExercises
                .OrderByDescending(d => d.ExerciseAddedTime)
                .Where(x => x.UserId == user.UserId && DbFunctions.TruncateTime(x.ExerciseAddedTime) == dt)
                .ToList();

            for (int i = 1; i <= exerciseList.Count; i++)
                dgvSummary.Rows.Add(Resources.exercise, exerciseList[i - 1].Exercise.ExerciseName, exerciseList[i - 1].Exercise.Duration, "Minute", 0 - exerciseList[i - 1].Exercise.BurnedEnergy, exerciseList[i - 1].ExerciseAddedTime.ToString("HH:mm"), exerciseList[i - 1].ExerciseAddedTime.ToString("HH:mm"));

            Dictionary<Meal, List<Food>> mealFoodList = new Dictionary<Meal, List<Food>>();
            var mealList = user.Meals.Where(x => x.Date.Date == DateTime.Now.Date).ToList();


            
            foreach (var item in mealList)
                mealFoodList.Add(item, item.Foods);

            foreach (var meal in mealFoodList)
                foreach (var food in meal.Value)
                    dgvSummary.Rows.Add(Resources.food, food.FoodName, food.Quantity, food.Porsion, food.FoodCalories, meal.Key.MealName, meal.Key.Date.ToString("HH:mm"));

            SortHiddenTimesOnDataGrid();

            CalculateBurnedConsumedEnergy(exerciseList, mealFoodList);
        }

        private void CalculateBurnedConsumedEnergy(List<UserExercise> exerciseList, Dictionary<Meal, List<Food>> mealFoodList)
        {
            double recomendedCalorieOfUser = 2000;
            string recommendMessage = $"We recommend you to get {recomendedCalorieOfUser}kcal per a day.\r\nYou currently have a kcal surplus/deficit of {recomendedCalorieOfUser} Calories.";
            tlpRecomended.SetToolTip(lblBudgetInfo,recommendMessage);
            double burnedEnergy = exerciseList.Sum(x => 0 - x.Exercise.BurnedEnergy);
            double consumedEnergy = mealFoodList.Keys.Sum(x => x.Foods.Sum(p => p.FoodCalories));

            lblBurned.Text = burnedEnergy.ToString();
            lblConsumed.Text = consumedEnergy.ToString();

            double budget = 0 - burnedEnergy - consumedEnergy;
            lblBudget.Text = budget.ToString();
        }

        private void SetWidthDataGrid()
        {
            dgvSummary.Columns[0].Width = (int)(dgvSummary.Width * 0.1);
            dgvSummary.Columns[1].Width = (int)(dgvSummary.Width * 0.3);
            dgvSummary.Columns[2].Width = (int)(dgvSummary.Width * 0.1);
            dgvSummary.Columns[3].Width = (int)(dgvSummary.Width * 0.14);
            dgvSummary.Columns[4].Width = (int)(dgvSummary.Width * 0.1);
            dgvSummary.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvSummary_SizeChanged(object sender, EventArgs e)
        {
            SetWidthDataGrid();
        }

        private void addExerciseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExerciseForm exerciseForm = new ExerciseForm();
            exerciseForm.ShowDialog();
            GetAllSummary();
        }

       
    }
}
