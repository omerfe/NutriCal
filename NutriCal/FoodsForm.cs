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
        NutriCalDbContext db = new NutriCalDbContext();

        private readonly string buttonText;
        private readonly Image mealPicture;
        User loggedUser;
        FoodCategory selectedCategory = new FoodCategory();
        Food selectedFood = new Food();
        List<Food> addedFoods = new List<Food>();

        public FoodsForm(string buttonText, Image mealPicture)
        {
            loggedUser = db.Users.ToList()[0];
            InitializeComponent();
            this.buttonText = buttonText;
            this.mealPicture = mealPicture;
            lblMealName.Text = buttonText;
            pboSelectedMeal.Image = mealPicture;
            CreateFoodCategoryList();
            btnAdd.Enabled = false;
            dgvFood.AutoGenerateColumns = false;
        }

        private void CreateFoodCategoryList()
        {
            cboFoodCategories.DataSource = db.FoodCategories.ToList();
            cboFoodCategories.DisplayMember = "CategoryName";
            cboFoods.DisplayMember = "FoodName";
        }

        private void cboFoodCategories_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedCategory = cboFoodCategories.SelectedItem as FoodCategory;
            cboFoods.DataSource = db.Foods.Where(x => x.FoodCategoryId == selectedCategory.FoodCategoryId).ToList();
        }
        private void cboFoods_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedFood = cboFoods.SelectedItem as Food;
            lblPorsion.Text = $"Porsion \t({selectedFood.Porsion})";

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var food = db.Foods.FirstOrDefault(x => x.FoodId == selectedFood.FoodId);
            food.TotalCalory = (double)nudPorsion.Value * food.FoodCalories;
            addedFoods.Add(db.Foods.FirstOrDefault(x => x.FoodId == selectedFood.FoodId));
            dgvFood.DataSource = addedFoods.ToList();
        }

        private void nudPorsion_ValueChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

    }
}


