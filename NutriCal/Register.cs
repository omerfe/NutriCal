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
    public partial class Register : Form
    {
        private readonly NutriCalDbContext db;
        bool isValidLength, isContainNumber, isContainUpperCase, isContainLowerCase, isContainSpecial;
        public Register(NutriCalDbContext db)
        {
            this.db = db;
            InitializeComponent();
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblControlConfirm.ForeColor = Color.Red;
                lblControlConfirm.Text = "Passwords do not match!";
                lblControlConfirm.Visible = true;
            }
            else
            {
                lblControlConfirm.ForeColor = Color.Green;
                lblControlConfirm.Text = "Passwords match!";
                lblControlConfirm.Visible = true;
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            char[] pwd = txtPassword.Text.ToCharArray();
            string numbers = "0123456789";
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string specialCharacters = "!@#/+%^-&*()";

            //for length
            if (pwd.Length < 8)
            {
                isValidLength = false;
                lblPC1.ForeColor = Color.Red;
            }
            else
            {
                isValidLength = true;
                lblPC1.ForeColor = Color.Green;
            }
            //for lower case
            foreach (var item in pwd.Distinct())
            {
                if (!lowerCase.Contains(item))
                {
                    isContainLowerCase = false;
                    lblPC2.ForeColor = Color.Red;
                }
                else
                {
                    isContainLowerCase = true;
                    lblPC2.ForeColor = Color.Green;
                }

            }
            //for upper case
            foreach (var item in pwd.Distinct())
            {
                if (!upperCase.Contains(item))
                {
                    isContainUpperCase = false;
                    lblPC3.ForeColor = Color.Red;
                }
                else
                {
                    isContainUpperCase = true;
                    lblPC3.ForeColor = Color.Green;
                }
            }
            //for numbers
            foreach (var item in pwd.Distinct())
            {
                if (!numbers.Contains(item))
                {
                    isContainNumber = false;
                    lblPC4.ForeColor = Color.Red;
                }
                else
                {
                    isContainNumber = true;
                    lblPC4.ForeColor = Color.Green;
                }
            }
            //for special characters
            foreach (var item in pwd.Distinct())
            {
                if (!specialCharacters.Contains(item))
                {
                    isContainSpecial = false;
                    lblPC5.ForeColor = Color.Red;
                }
                else
                {
                    isContainSpecial = true;
                    lblPC5.ForeColor = Color.Green;
                }
            }
        } //sorun var, hepsini aynı anda yapamıyo
        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Email = txtEmail.Text.Trim();
            userLogin.Password = txtPassword.Text;

            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    lblControlEmail.ForeColor = Color.Gold;
                    lblControlEmail.Text = "Field cannot be empty!";
                    lblControlEmail.Visible = true;
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    lblControlPassword.ForeColor = Color.Gold;
                    lblControlPassword.Text = "Field cannot be empty!";
                    lblControlPassword.Visible = true;
                }
                if (string.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    lblControlConfirm.ForeColor = Color.Gold;
                    lblControlConfirm.Text = "Field cannot be empty!";
                    lblControlConfirm.Visible = true;
                }
                return;
            }

            if (isValidLength == false || isContainNumber == false || isContainUpperCase == false || isContainLowerCase == false && isContainSpecial == false)
            {
                lblControlTotalPwd.Visible = true;
                return;
            }

            foreach (var item in db.UserLogins)
            {
                if (item.Email == userLogin.Email)
                {
                    MessageBox.Show("User already registered!");
                    return;
                }
            }

            db.UserLogins.Add(userLogin);
            db.SaveChanges();
            MessageBox.Show("Success! Your account has been created!");
            Close();
        } //sorun var 

    }
}
