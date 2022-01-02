﻿using NutriCal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriCal
{
    public partial class NutriCalMainPage : Form
    {
        public NutriCalMainPage()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MealsForm form = new MealsForm();
            form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}