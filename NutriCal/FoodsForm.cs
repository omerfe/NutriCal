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
            Text = meal.MealName;
            lblMealName.Text = meal.MealName;
            pboSelectedMeal.Image = mealPicture;
        }
        private void UpdateFoods()
        {
            if (meal.Foods.Count > 0)
            {
                dgvFood.DataSource = meal.Foods.Select(x => new
                {
                    Name = x.FoodName,
                    Porsion = $"{nudPorsion.Value} {x.Porsion}(s)",
                    Category = x.FoodCategory.CategoryName,
                    Calories = $"{x.FoodCalories * (double)nudPorsion.Value}kcal"

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

            //TODO: düzelt
            List<Food> foods = db.Foods.Where(x => x.FoodCategoryId == selectedCategory.FoodCategoryId && (x.FoodRole == "0" || x.FoodRole == user.UserId.ToString())).ToList();
            List<Food> finalFoods = new List<Food>();
            for (int i = 0; i < foods.Count; i++)
            {
                for (int j = i + 1; j < foods.Count + 1; j++)
                {
                    if (!finalFoods.Any(x=>x.FoodName == foods[i].FoodName))
                    {
                        finalFoods.Add(foods[i]);
                    }
                }
            }
            cboFoods.DataSource = finalFoods;
        }
        private void cboFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food selectedFood = cboFoods.SelectedItem as Food;
            lblPorsion.Text = $"Porsion\n({selectedFood.Porsion})";
            lblFood.Text = selectedFood.FoodName;
            pboFood.Load(selectedFood.FoodImage);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Food selectedFood = (Food)cboFoods.SelectedItem;
            Food food = new Food()
            {
                FoodName = selectedFood.FoodName,
                FoodCategory = selectedFood.FoodCategory,
                Porsion = selectedFood.Porsion,
                FoodRole = user.UserId.ToString(),
                Quantity = (int)nudPorsion.Value,
                FoodCalories = selectedFood.FoodCalories
            };
            meal.Foods.Add(food);
            meal.TotalCalories += food.FoodCalories;
            MessageBox.Show("Test");
            db.SaveChanges();
            UpdateFoods();
        }
        private void btnAddCustom_Click(object sender, EventArgs e)
        {
            new FoodEditForm(new FoodCategory(), new Food(), db, user, meal).ShowDialog();
            UpdateFoods();
        }
        private void btnSaveMeal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your meal has been saved!");
            Close();
        }
    }
}