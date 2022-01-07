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
    public partial class FoodsForm : Form
    {
        private readonly NutriCalDbContext db;
        private readonly Meal meal;
        private readonly Image mealPicture;
        private readonly User user;

        public FoodsForm(NutriCalDbContext db, Meal meal, Image mealPicture, User user)
        {
            InitializeComponent();
            this.db = db;
            this.meal = meal;
            this.mealPicture = mealPicture;
            this.user = user;
            GetMealProps();
            CreateFoodCategoryList();
            UpdateFoods();
        }

        private void GetMealProps()
        {
            Text = DateTime.Now.ToString("dd.MM.yyyy");
            groupBox1.Text = meal.MealName;
            pboSelectedMeal.Image = mealPicture;
        }
        private void UpdateFoods()
        {
            // database ilk çalıştırıldığında exception verebilir
            if (meal.Foods.Count >= 0)
            {
                dgvFood.DataSource = meal.Foods.Select(x => new
                {
                    Name = x.FoodName,
                    Porsion = $"{x.Quantity} {x.Porsion}(s)",
                    Category = x.FoodCategory.CategoryName,
                    Calories = $"{x.FoodCalories * x.Quantity}kcal"
                }).ToList();
            }
        }
        private void CreateFoodCategoryList()
        {
            cboFoodCategories.DataSource = db.FoodCategories.ToList();
            cboFoodCategories.DisplayMember = "CategoryName";

        }
        private void cboFoodCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodCategory selectedCategory = cboFoodCategories.SelectedItem as FoodCategory;
            cboFoods.DisplayMember = "FoodName";

            List<Food> foods = db.Foods.Where(x => x.FoodCategoryId == selectedCategory.FoodCategoryId && (x.FoodRole == "0" || x.FoodRole == user.UserId.ToString())).ToList();
            List<Food> finalFoods = new List<Food>();

            for (int i = 0; i < foods.Count; i++)
            {
                if (!finalFoods.Any(x => x.FoodName == foods[i].FoodName))
                {
                    finalFoods.Add(foods[i]);
                }
            }

            cboFoods.DataSource = finalFoods;
        }
        private void cboFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food selectedFood = cboFoods.SelectedItem as Food;
            lblPorsion.Text = $"Porsion ({selectedFood.Porsion})";
            pboFood.Load(selectedFood.FoodImage);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Food selectedFood = (Food)cboFoods.SelectedItem;
            Food food = new Food()
            {
                FoodName = selectedFood.FoodName,
                FoodImage = selectedFood.FoodImage,
                FoodCategory = selectedFood.FoodCategory,
                Porsion = selectedFood.Porsion,
                FoodRole = user.UserId.ToString(),
                Quantity = (int)nudPorsion.Value,
                FoodCalories = selectedFood.FoodCalories
            };
            meal.Foods.Add(food);
            meal.TotalCalories += food.FoodCalories;

            db.SaveChanges();
            UpdateFoods();
        }
        private void btnAddCustom_Click(object sender, EventArgs e)
        {
            new FoodEditForm(new FoodCategory(), new Food(), db, user, meal).ShowDialog();
            UpdateFoods();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count > 0)
            {
                string selectedFoodName = dgvFood.SelectedRows[0].Cells[0].Value.ToString();
                Food selectedFood = meal.Foods.FirstOrDefault(x => x.FoodName == selectedFoodName);
                DialogResult dr = MessageBox.Show($"Are you sure you wanted to delete {selectedFoodName}?", "Warning!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    meal.Foods.Remove(selectedFood);
                meal.TotalCalories -= selectedFood.FoodCalories;
                db.SaveChanges();
            }
            UpdateFoods();
        }
        private void FoodsForm_Load(object sender, EventArgs e)
        {
            dgvFood.ClearSelection();
        }
        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count > 0)
            {
                string selectedFoodName = dgvFood.SelectedRows[0].Cells[0].Value.ToString();
                Food selectedFood = meal.Foods.FirstOrDefault(x => x.FoodName == selectedFoodName);
                new FoodEditForm(selectedFood.FoodCategory, selectedFood, db, user, meal).ShowDialog();
            }
            db.SaveChanges();
            UpdateFoods();
        }
    }
}