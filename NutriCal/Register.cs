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
    public partial class Register : Form
    {
        private readonly NutriCalDbContext db;
        bool isValidLength, isContainNumber, isContainUpperCase, isContainLowerCase, isContainSpecial;
        public Register(NutriCalDbContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadGenders();
        }
        private void LoadGenders()
        {
            cmbUserGender.DataSource = null;
            cmbUserGender.DataSource = Enum.GetNames(typeof(Genders)).ToArray();
            //cmbUserGender.DataSource = Enum.GetValues(typeof(Genders));
            //bunu yapınca güncelleme yaparken selected item'ı user.Genders yapılmadı o yüzden string olarak tutunca çözüldü
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
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

            if (pwd.Length < 8)
            {
                isValidLength = false;
            }
            else
            {
                isValidLength = true;
                lblPC1.ForeColor = Color.Green;
            }
            foreach (var item in pwd.Distinct())
            {
                if (lowerCase.Contains(item))
                {
                    isContainLowerCase = true;
                    lblPC2.ForeColor = Color.Green;
                }
                else if (upperCase.Contains(item))
                {
                    isContainUpperCase = true;
                    lblPC3.ForeColor = Color.Green;
                }
                else if (numbers.Contains(item))
                {
                    isContainNumber = true;
                    lblPC4.ForeColor = Color.Green;
                }
                else if (specialCharacters.Contains(item))
                {
                    isContainSpecial = true;
                    lblPC5.ForeColor = Color.Green;
                }
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtUserSurname.Text))
            {
                lblPersonalInfoCheck.Visible = true;
                lblPersonalInfoCheck.ForeColor = Color.Gold;
                lblPersonalInfoCheck.Text = "These fields cannot be empty!";
                return;
            }
            user.UserName = txtUserName.Text.Trim();
            user.UserSurname = txtUserSurname.Text.Trim();
            user.BirthDate = dtpUserBirthDate.Value;
            user.Weight = (double)nudUserWeight.Value;
            user.Height = (int)nudUserHeight.Value;
            if (cmbUserGender.SelectedIndex != -1)
            {
                string gender = (string)cmbUserGender.SelectedItem;
                user.Gender = (Genders)Enum.Parse(typeof(Genders), gender);
            }
            else
            {
                lblPersonalInfoCheck.Visible = true;
                lblPersonalInfoCheck.ForeColor = Color.Gold;
                lblPersonalInfoCheck.Text = "These fields cannot be empty!";
                return;
            }
            
            UserLogin userLogin = new UserLogin();
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
            userLogin.Email = txtEmail.Text.Trim();
            userLogin.Password = txtPassword.Text;

            if (isValidLength == false || isContainNumber == false || isContainUpperCase == false || isContainLowerCase == false || isContainSpecial == false)
            {
                lblControlTotalPwd.Visible = true;
                return;
            }

            foreach (var item in db.UserLogins)
            {
                if (item.Email == userLogin.Email)
                {
                    MessageBox.Show("User already registered! Please LOG IN!!!");
                    ClearRegisterForm();
                    btnLogin.Visible = true;
                    return;
                }
            }

            db.UserLogins.Add(userLogin);
            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Success! Your account has been created!");
            ClearRegisterForm();
            Close();
        }
        private void ClearRegisterForm()
        {
            txtEmail.Clear();
            lblControlEmail.Visible = false;
            txtPassword.Clear();
            lblControlPassword.Visible = false;
            txtConfirmPassword.Clear();
            lblControlConfirm.Visible = false;
            chkShowPassword.Checked = false;
            lblPC1.ForeColor = Color.Silver;
            lblPC2.ForeColor = Color.Silver;
            lblPC3.ForeColor = Color.Silver;
            lblPC4.ForeColor = Color.Silver;
            lblPC5.ForeColor = Color.Silver;
            lblControlConfirm.Visible = false;
            lblControlTotalPwd.Visible = false;
            btnLogin.Visible = false;
            txtUserName.Clear();
            txtUserSurname.Clear();
            dtpUserBirthDate.Value = DateTime.Now;
            nudUserWeight.Value = 50;
            nudUserHeight.Value = 150;
        }
    }
}
