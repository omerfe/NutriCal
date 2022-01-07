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
    public partial class LoginForm : Form
    {
        NutriCalDbContext db = new NutriCalDbContext();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LnkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm(db);
            register.Show();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLogin loggedIn = db.UserLogins.FirstOrDefault(x => x.Email == txtEmail.Text && x.Password == txtPassword.Text);

            if (loggedIn == null)
            {
                MessageBox.Show("Username or password is incorrect!");
            }
            else
            {
                User user = db.Users.FirstOrDefault(x => x.UserId == loggedIn.UserLoginId);
                MainForm mainForm = new MainForm(db, user);
                mainForm.Show();
                txtEmail.Text = "";
                txtPassword.Text = "";

            }
        }

    }
}
