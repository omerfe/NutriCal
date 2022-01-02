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
    public partial class MealsForm : Form
    {
        NutriCalDbContext db = new NutriCalDbContext();
        public MealsForm()
        {
            InitializeComponent();
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            FoodsForm foodsForm = new FoodsForm(btnBreakfast.Text, pboBreakfast.Image);
            foodsForm.ShowDialog();
        }

        private void btnMorningSnack_Click(object sender, EventArgs e)
        {
            FoodsForm foodsForm = new FoodsForm(btnMorningSnack.Text, pboMorningSnack.Image);
            foodsForm.ShowDialog();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            FoodsForm foodsForm = new FoodsForm(btnLunch.Text, pboLunch.Image);
            foodsForm.ShowDialog();
        }

        private void btnAfternoonSnack_Click(object sender, EventArgs e)
        {
            FoodsForm foodsForm = new FoodsForm(btnAfternoonSnack.Text, pboAfternoonSnack.Image);
            foodsForm.ShowDialog();
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            FoodsForm foodsForm = new FoodsForm(btnDinner.Text, pboDinner.Image);
            foodsForm.ShowDialog();
        }
    }
}
