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
        //NutriCalDbContext db = new NutriCalDbContext();
        //User loggedUser;
        private readonly NutriCalDbContext db;
        private readonly Meal meal;
        private readonly User user;
        private readonly Image mealPicture;
        //--------------------------
        //FoodCategory selectedCategory = new FoodCategory();
        //Food selectedFood = new Food();
        //List<Food> addedFoods = new List<Food>();


        public FoodsForm(NutriCalDbContext db, Meal meal, Image mealPicture)
        {
            InitializeComponent();
            this.db = db;
            this.meal = meal;
            this.mealPicture = mealPicture;
            lblMealName.Text = meal.MealName;
            pboSelectedMeal.Image = mealPicture;

            CreateFoodCategoryList();
            UpdateFoods();

            btnAdd.Enabled = false;
            dgvFood.AutoGenerateColumns = false;
        }

        private void UpdateFoods()
        {
            dataGridView1.DataSource = meal.Foods.Select(x => new
            {

                Name = x.FoodName,
                Porsion = x.Porsion,
                Category = x.CategoryName,
                Calory = $"{(decimal)x.FoodCalories * nudPorsion.Value}kcal"

            }).ToList();
        }

        private void CreateFoodCategoryList()
        {
            cboFoodCategories.DataSource = db.FoodCategories.ToList();
            cboFoodCategories.DisplayMember = "CategoryName";

            //cboFoods.DisplayMember = "FoodName";
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Food selectedFood = (Food)cboFoods.SelectedItem;
            meal.Foods.Add(selectedFood);
            meal.TotalCalories += selectedFood.FoodCalories;


            MessageBox.Show("Test");
            db.SaveChanges();
            UpdateFoods();

            //var food = db.Foods.FirstOrDefault(x => x.FoodId == selectedFood.FoodId);

            //food.TotalCalory = (double)nudPorsion.Value * food.FoodCalories;

            //addedFoods.Add(db.Foods.FirstOrDefault(x => x.FoodId == selectedFood.FoodId));
            //dgvFood.DataSource = addedFoods.ToList();

        }

        private void nudPorsion_ValueChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void cboFoodCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodCategory selectedCategory = cboFoodCategories.SelectedItem as FoodCategory;
            cboFoods.DisplayMember = "FoodName";
            cboFoods.DataSource = db.Foods.Where(x => x.FoodCategoryId == selectedCategory.FoodCategoryId).ToList();
        }

        private void cboFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food selectedFood = cboFoods.SelectedItem as Food;
            lblPorsion.Text = $"Porsion \t({selectedFood.Porsion})";
        }
    }
}


