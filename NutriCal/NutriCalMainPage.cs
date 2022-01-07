using NutriCal.Models;
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

    

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Close();
        }
    }
}
