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

            //CreateReportBySelection(); //ilk yaptığım kısım
            DailyCaloriesByMeals();
            //Gün sonunda kişisel olarak yediğimiz öğünlerde bulunan kaloriyi öğün bazlı ve toplam olarak görmek isteriz.

            ListFoodsByMeals();
            //Hangi yemeklerin hangi öğünlerde ne kadar yendiğini gösteren bir rapor hazırlansın.
            //En çok yenen yemekler raporu çıksın.
            //Sayılarını ekle!

            //ListMeals();
            //Yediğimiz öğünleri haftalık/aylık bazda tüm kişiler ile öğün bazlı ve yemek kategorisi bazlı kıyaslamasını raporlasın.
           
        }


        //private void ListMeals()
        //{
        //Öğünlerin haftalık/aylık kalori ortalaması (kendisi ve tüm kişiler)
        //Comboboxtan kategori seçip foodları listele
        //    //Öğünleri haftalık/aylık, öğün ve yemek kategorisi bazlı(TÜM KİŞİLER)
        //    List<Meal> mealList = new List<Meal>();
        //    DateTime dt = DateTime.Now;

        //    switch (cmbTimeInt.SelectedIndex)
        //    {
        //        case 0: //şuan last 1week, seçilen hafta için haftalık yapılacak?
        //            dt = dt.AddDays(-7);
        //            break;
        //        case 1: //şuan last 1 month, seçilen ay için aylık yapılacak?
        //            dt = dt.AddMonths(-1);
        //            break;
        //    }
        //    switch (cmbBy.SelectedIndex)
        //    {
        //        case 0: //Öğün bazlı
        //            dgvXXX.DataSource = mealList.OrderByDescending(x => x.MealName);
        //            break;
        //        case 1: //yemek kategorisi bazlı
        //            dgvXXX.DataSource = mealList.OrderByDescending(x => x.CategoryName); //Foods->FoodCategories.CategoryName???
        //            break;
        //    }
        //}

        private void ListFoodsByMeals()
        {
            //Tüm yemekleri öğünlere göre listeleyeceğiz(TÜM KİŞİLER)
            //Breakfast harici diğer öğünleri yap!
            List<Food> foodList = new List<Food>();
            string selectedText ="";
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
            {
                foreach (var food in meal.Foods)
                {
                    foodList.Add(food);
                }
            }

            dgvFoods.DataSource = foodList.Select(x => new
            { 
                x.FoodName,
                x.FoodCalories
            }).ToList();
        }

        private void DailyCaloriesByMeals()
        {
            //Boş olduğunda label isimleri görünüyo düzelt
            var dt = DateTime.Now.Date;
            gbDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lblUser.Text = $"{user.UserName} {user.UserSurname}'s Daily Consumption";


            double totalBreakfastCal = 0, totalMorningSnackCal = 0, totalLunchCal = 0, totalAfternoonSnackCal = 0, totalDinnerCal = 0;
            var userBreakfast = user.Meals.FirstOrDefault(x => x.MealName == "Breakfast" && x.Date.Date == dt);
            if (userBreakfast != null)
            {
                totalBreakfastCal = userBreakfast.Foods.Sum(x => x.FoodCalories);
                lblBreakfast.Text = $"{totalBreakfastCal}kcal";
            }

            var userMorningSnack = user.Meals.FirstOrDefault(x => x.MealName == "Morning Snack" && x.Date.Date == dt);
            if (userMorningSnack != null)
            {
                totalMorningSnackCal = userMorningSnack.Foods.Sum(x => x.FoodCalories);
                lblMorningSnack.Text = $"{totalMorningSnackCal}kcal";
            }

            var userLunch = user.Meals.FirstOrDefault(x => x.MealName == "Lunch" && x.Date.Date == dt);
            if (userLunch != null)
            {
                totalLunchCal = userLunch.Foods.Sum(x => x.FoodCalories);
                lblLunch.Text = $"{totalLunchCal}kcal";
            }


            var userAfternoonSnack = user.Meals.FirstOrDefault(x => x.MealName == "Afternoon Snack" && x.Date.Date == dt);
            if (userAfternoonSnack != null)
            {
                totalAfternoonSnackCal = userAfternoonSnack.Foods.Sum(x => x.FoodCalories);
                lblAfternoonSnack.Text = $"{totalAfternoonSnackCal}kcal";
            }


            var userDinner = user.Meals.FirstOrDefault(x => x.MealName == "Dinner" && x.Date.Date == dt);
            if (userDinner != null)
            {
                totalDinnerCal = userDinner.Foods.Sum(x => x.FoodCalories);
                lblDinner.Text = $"{totalDinnerCal}kcal";
            }

            double totalCal = totalBreakfastCal + totalMorningSnackCal + totalLunchCal + totalAfternoonSnackCal + totalDinnerCal;
            lblTotalCalories.Text = $"{totalCal}kcal";
        }

        private void cmbMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListFoodsByMeals();
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
            
        }
    }
}
