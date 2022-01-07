using NutriCal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriCal
{
    public partial class FoodEditForm : Form
    {
        private readonly FoodCategory foodCategory;
        private readonly Food food;
        private readonly NutriCalDbContext db;
        private readonly User user;
        private readonly Meal meal;

        public FoodEditForm(FoodCategory foodCategory, Food food, NutriCalDbContext db, User user, Meal meal)
        {
            InitializeComponent();
            this.foodCategory = foodCategory;
            this.food = food;
            this.db = db;
            this.user = user;
            this.meal = meal;
            LoadElements();
            if (food.FoodId > 0)
                PrepareEditForm();
            else
                PrepareAddForm();
        }

        private void LoadElements()
        {
            cboCategory.DataSource = db.FoodCategories.ToList();
            cboCategory.DisplayMember = "CategoryName";
            cboPorsion.DataSource = Enum.GetValues(typeof(Enums.Porsions));
        }
        private void PrepareEditForm()
        {
            Text = $"Editing: {food.FoodName}";
            LoadElements();
            cboCategory.SelectedItem = foodCategory;
            cboCategory.Enabled = false;
            txtCustomFoodName.Text = food.FoodName;
            txtCustomFoodName.Enabled = false;
            txtCustomFoodImage.Text = food.FoodImage;
            cboPorsion.SelectedItem = food.Porsion;
            cboPorsion.Enabled = false;
            nudPorsion.Value = food.Quantity;
            nudCalories.Value = (decimal)food.FoodCalories;
            nudCalories.Enabled = false;
            btnAdd.Text = "Save";
        }
        private void PrepareAddForm()
        {
            Text = "Adding Custom Food:";
            txtCustomFoodName.Text = "Enter Food Name:";
            txtCustomFoodImage.Text = "Enter Food Image URL:";
            LoadElements();
            cboPorsion.SelectedIndex = 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Save")
            {
                food.FoodCategory = cboCategory.SelectedItem as FoodCategory;
                food.FoodName = txtCustomFoodName.Text;
                food.FoodImage = txtCustomFoodImage.Text;
                food.Porsion = (Enums.Porsions)cboPorsion.SelectedItem;
                food.Quantity = (int)nudPorsion.Value;
                food.FoodCalories = (double)nudCalories.Value;
                food.FoodRole = user.UserId.ToString();
                MessageBox.Show($"{food.FoodName} updated successfully!");
                Close();
            }
            else
            {
                Food newFood = new Food()
                {
                    FoodCategory = cboCategory.SelectedItem as FoodCategory,
                    FoodName = txtCustomFoodName.Text,
                    FoodImage = txtCustomFoodImage.Text,
                    Porsion = (Enums.Porsions)cboPorsion.SelectedItem,
                    Quantity = (int)nudPorsion.Value,
                    FoodCalories = (double)nudCalories.Value,
                    FoodRole = user.UserId.ToString()
                };

                db.Foods.Add(newFood);
                meal.Foods.Add(newFood);
                MessageBox.Show($"{newFood.FoodName} added successfully!");
            }
            db.SaveChanges();
        }
        private void cboPorsion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCalories.Text = $"Calorie(s) per {cboPorsion.SelectedItem}:";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void nudPorsion_ValueChanged(object sender, EventArgs e)
        {
            lblTotalCalories.Text = $"Total Calories: { nudPorsion.Value * nudCalories.Value }";
        }
        private void nudCalories_ValueChanged(object sender, EventArgs e)
        {
            lblTotalCalories.Text = $"Total Calories: { nudPorsion.Value * nudCalories.Value }";
        }
    }
}