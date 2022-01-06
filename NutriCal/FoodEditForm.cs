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
            PrepareAddForm();
        }



        private void PrepareAddForm()
        {
            cboCategory.DataSource = db.FoodCategories.ToList();
            cboCategory.DisplayMember = "CategoryName";
            txtCustomFoodName.Text = "Enter Food Name:";
            txtCustomFoodImage.Text = "Enter Food Image URL:";

            foreach (var item in Enum.GetValues(typeof(Enums.Porsions)))
            {
                cboPorsion.Items.Add(item);
            }
            cboPorsion.SelectedIndex = 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
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
            db.SaveChanges();
            MessageBox.Show($"{newFood.FoodName} added successfully!");
        }


        private void cboPorsion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCalories.Text = $"Calorie(s) per {cboPorsion.SelectedItem}:";
        }
    }
}