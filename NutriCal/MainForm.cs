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
        private readonly NutriCalDbContext db;
        private readonly User user;

        public MainForm(NutriCalDbContext db, User user)
        {
            this.db = db;
            this.user = user;


            InitializeComponent();

            SetWidthDataGrid();
            GetFoodsByChoosenTime(DateTime.Now);
            GetExercisesByChoosenTime(DateTime.Now);
            SortHiddenTimesOnDataGrid();
            Text = $"Welcome {user.UserName} {user.UserSurname.ToUpper()}";
        }
        #region DataGridViewArea
        private void SortHiddenTimesOnDataGrid() => dgvSummary.Sort(dataGridViewColumn: dgvSummary.Columns[dgvSummary.ColumnCount - 1], direction: ListSortDirection.Descending);
        private void SetWidthDataGrid()
        {
            dgvSummary.Columns[0].Width = (int)(dgvSummary.Width * 0.1);
            dgvSummary.Columns[1].Width = (int)(dgvSummary.Width * 0.23);
            dgvSummary.Columns[2].Width = (int)(dgvSummary.Width * 0.1);
            dgvSummary.Columns[3].Width = (int)(dgvSummary.Width * 0.14);
            dgvSummary.Columns[4].Width = (int)(dgvSummary.Width * 0.1);
            dgvSummary.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSummary.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void dgvSummary_SizeChanged(object sender, EventArgs e)
        {
            SetWidthDataGrid();
        }

        #endregion

        #region Food Area
        private void GetFoodsByChoosenTime(DateTime dt)
        {
            var mealList = user.Meals.Where(x => x.Date.Date == dt).ToList();
            GetFoods(mealList);
            CalculateBurnedConsumedEnergy(mealList: mealList);
        }

        private void GetFoodsByChoosenTime(DateTime start, DateTime end)
        {
            var mealList = user.Meals.Where(x => x.Date.Date >= start.Date && x.Date.Date <= end.Date).ToList();
            GetFoods(mealList);
            CalculateConsumedEnergy(mealList);
        }

        private void GetFoods(List<Meal> mealList)
        {

            Dictionary<Meal, List<Food>> mealFoodList = new Dictionary<Meal, List<Food>>();

            foreach (var item in mealList)
                mealFoodList.Add(item, item.Foods);

            foreach (var meal in mealFoodList)
                foreach (var food in meal.Value)
                    dgvSummary.Rows.Add(Resources.food, food.FoodName, food.Quantity, food.Porsion, food.FoodCalories, meal.Key.MealName, meal.Key.Date);

            SortHiddenTimesOnDataGrid();
        }
        #endregion

        #region ExerciseArea
        private void GetExercisesByChoosenTime(DateTime dt)
        {
            var deneme = db.Exercises.ToList();
            var exerciseList = db.UserExercises
                .OrderByDescending(d => d.ExerciseAddedTime)
                .Where(x => x.UserId == user.UserId && DbFunctions.TruncateTime(x.ExerciseAddedTime) == dt.Date)
                .ToList();
            GetExercises(exerciseList);
            CalculateBurnedConsumedEnergy(exerciseList: exerciseList);
        }
        private void GetExercisesByChoosenTime(DateTime start, DateTime end)
        {
            var deneme = db.Exercises.ToList();
            var exerciseList = db.UserExercises
                .OrderByDescending(d => d.ExerciseAddedTime)
                .Where(x => x.UserId == user.UserId && DbFunctions.TruncateTime(x.ExerciseAddedTime) >= start.Date && DbFunctions.TruncateTime(x.ExerciseAddedTime) <= end.Date)
                .ToList();
            GetExercises(exerciseList);
            CalculateBurnedEnergy(exerciseList);

        }

        private void GetExercises(List<UserExercise> exerciseList)
        {
            //Validate 
            if (dgvSummary.Rows.Count != 0)
                dgvSummary.Rows[0].Selected = true;

            for (int i = 1; i <= exerciseList.Count; i++)
                dgvSummary.Rows.Add(Resources.exercise, exerciseList[i - 1].Exercise.ExerciseName, exerciseList[i - 1].Exercise.Duration, "Minute", 0 - exerciseList[i - 1].Exercise.BurnedEnergy, exerciseList[i - 1].ExerciseAddedTime.ToString("HH:mm"), exerciseList[i - 1].ExerciseAddedTime);
            SortHiddenTimesOnDataGrid();
        }
        #endregion

        #region Energy Calculation
        private void CalculateBurnedConsumedEnergy(List<Meal> mealList = null, List<UserExercise> exerciseList = null)
        {
            double recomendedCalorieOfUser = 2000; //UNDONE: Kullanıcıya önerilen kalori buraya verilecek.
            string recommendMessage = $"We recommend you to get {recomendedCalorieOfUser}kcal per a day.\r\nYou currently have a kcal surplus/deficit of {recomendedCalorieOfUser} Calories.";
            tlpRecomended.SetToolTip(lblBudgetInfo, recommendMessage);


            double burnedEnergy = 0, consumedEnergy = 0;

            if (mealList != null)
            {
                consumedEnergy = mealList.Sum(x => x.TotalCalories);
                lblConsumed.Text = consumedEnergy.ToString();
            }
            else
            {
                burnedEnergy = exerciseList.Sum(x => 0 - x.Exercise.BurnedEnergy);
                lblBurned.Text = burnedEnergy.ToString();
            }

            double budget = Convert.ToDouble(lblBurned.Text) + Convert.ToDouble(lblConsumed.Text);
            lblBudget.Text = budget.ToString();
        }
        private void CalculateBurnedEnergy(List<UserExercise> exerciseList)
        {
            double burnedTotalEnergy = exerciseList.Sum(x => 0 - x.Exercise.BurnedEnergy);
            lblBurned.Text = burnedTotalEnergy.ToString();
        }
        private void CalculateConsumedEnergy(List<Meal> mealList)
        {
            double consumedTotalEnergy = mealList.Sum(x => x.TotalCalories);
            lblConsumed.Text = consumedTotalEnergy.ToString();
        }
        #endregion

        #region All Form Control Events
        private void addExerciseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExerciseForm exerciseForm = new ExerciseForm(db, user);
            exerciseForm.ShowDialog();
            GetBothFoodExerciseOfToday();
        }

        private void mcDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (mcDate.SelectionRange.Start < DateTime.Now)
                GetBothFoodExerciseOfToday();
            lblDateInfo.Text = "";
            cmbCalorieBurnType.SelectedIndex = -1;
            cmbDateScala.SelectedIndex = -1;
            dgvSummary.Columns[dgvSummary.ColumnCount - 1].Visible = false;

        }



        private void lblShowToday_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mcDate.SelectionRange.Start = DateTime.Now;
            GetBothFoodExerciseOfToday();
            lblDateInfo.Text = "";
            cmbCalorieBurnType.SelectedIndex = -1;
            cmbDateScala.SelectedIndex = -1;

            dgvSummary.Columns[dgvSummary.ColumnCount - 1].Visible = false;

        }
        #endregion
        private void GetBothFoodExerciseOfToday()
        {
            dgvSummary.Rows.Clear();
            GetExercisesByChoosenTime(mcDate.SelectionRange.Start);
            GetFoodsByChoosenTime(mcDate.SelectionRange.Start);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //private void cmbCalorieBurnType_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    cmbDateScala.Enabled = true;
        //    dgvSummary.Rows.Clear();
        //    switch (cmbCalorieBurnType.SelectedIndex)
        //    {
        //        case 0:
        //            GetExercisesByChoosenTime(mcDate.SelectionRange.Start);
        //            pnlBurned.Show();
        //            pnlConsumed.Hide();
        //            pnlBudget.Hide();
        //            break;
        //        case 1:
        //            pnlConsumed.Show();
        //            pnlBurned.Hide();
        //            pnlBudget.Hide();
        //            GetFoodsByChoosenTime(mcDate.SelectionRange.Start);
        //            break;
        //        case 2:
        //            pnlConsumed.Show();
        //            pnlBurned.Show();
        //            pnlBudget.Show();
        //            GetBothFoodExerciseOfToday();
        //            break;

        //        default:
        //            pnlConsumed.Show();
        //            pnlBurned.Show();
        //            pnlBudget.Show();
        //            GetBothFoodExerciseOfToday();
        //            break;
        //    }
        //}

        //private void cmbDateScala_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    DateTime dt = DateTime.Now;
        //    dgvSummary.Rows.Clear();
        //    dgvSummary.Columns[dgvSummary.ColumnCount - 1].Visible = true;
        //    switch (cmbDateScala.SelectedIndex)
        //    {
        //        case 0:
        //            dt = dt.AddDays(-7);
        //            break;
        //        case 1:
        //            dt = dt.AddDays(-14);
        //            break;
        //        case 2:
        //            dt = dt.AddMonths(-1);
        //            break;
        //        case 3:
        //            dt = dt.AddMonths(-3);
        //            break;
        //        default:
        //            GetExercisesByChoosenTime(dt, DateTime.Now);
        //            GetFoodsByChoosenTime(dt, DateTime.Now);
        //            return;
        //    }
        //    string infoEnergyBurnType = "";
        //    if (cmbCalorieBurnType.SelectedIndex == 0)
        //    {
        //        GetExercisesByChoosenTime(dt, DateTime.Now);
        //        infoEnergyBurnType = "exercises";
        //    }
        //    else if (cmbCalorieBurnType.SelectedIndex == 1)
        //    {

        //        GetFoodsByChoosenTime(dt, DateTime.Now);
        //        infoEnergyBurnType = "foods";
        //    }
        //    else
        //    {
        //        GetExercisesByChoosenTime(dt, DateTime.Now);
        //        GetFoodsByChoosenTime(dt, DateTime.Now);
        //        infoEnergyBurnType = "everything";
        //    }

        //    lblDateInfo.Text = $"Showing up ({dgvSummary.Rows.Count}) your {infoEnergyBurnType} you have done from {dt.ToString("dd.MM.yyyy")} till today.";
        //}

        private void btnGetEnergyHistory_Click(object sender, EventArgs e)
        {
            if (cmbCalorieBurnType.SelectedIndex == -1)
            {
                MessageBox.Show("Test");
                return;
            }
            dgvSummary.Rows.Clear();
            dgvSummary.Columns[dgvSummary.ColumnCount - 1].Visible = true;
            DateTime dt = DateTime.Now;
            string infoEnergyBurnType = "";

            switch (cmbDateScala.SelectedIndex)
            {
                case 0:
                    dt = dt.AddDays(-7);
                    break;
                case 1:
                    dt = dt.AddDays(-14);
                    break;
                case 2:
                    dt = dt.AddMonths(-1);
                    break;
                case 3:
                    dt = dt.AddMonths(-3);
                    break;
            }
            switch (cmbCalorieBurnType.SelectedIndex)
            {
                case 0:
                    pnlBurned.Show();
                    pnlConsumed.Hide();
                    pnlBudget.Hide();
                    GetExercisesByChoosenTime(dt, DateTime.Now);
                    infoEnergyBurnType = "exercises";
                    break;
                case 1:
                    pnlConsumed.Show();
                    pnlBurned.Hide();
                    pnlBudget.Hide();
                    GetFoodsByChoosenTime(dt, DateTime.Now);
                    infoEnergyBurnType = "foods";
                    break;

                case 2:
                    pnlConsumed.Show();
                    pnlBurned.Show();
                    pnlBudget.Show();
                    GetExercisesByChoosenTime(dt, DateTime.Now);
                    GetFoodsByChoosenTime(dt, DateTime.Now);
                    infoEnergyBurnType = "everything";
                    break;

            }

            lblDateInfo.Text = $"Showing up ({dgvSummary.Rows.Count}) your {infoEnergyBurnType} you have done from {dt.ToString("dd.MM.yyyy")} till today.";

        }
    }
}
