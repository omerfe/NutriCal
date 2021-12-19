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
    public partial class Form1 : Form
    {
        NutriCalDbContext db = new NutriCalDbContext();
        public Form1()
        {
            InitializeComponent();
        }


    }
}
