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
            Thread.Sleep(100000);
            Login login = new Login();
            login.ShowDialog();
        }

    }
}
