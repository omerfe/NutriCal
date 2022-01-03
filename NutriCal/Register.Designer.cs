
namespace NutriCal
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.lblControlConfirm = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblControlTotalPwd = new System.Windows.Forms.Label();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblPC1 = new System.Windows.Forms.Label();
            this.lblPC2 = new System.Windows.Forms.Label();
            this.lblPC3 = new System.Windows.Forms.Label();
            this.lblPC4 = new System.Windows.Forms.Label();
            this.lblPC5 = new System.Windows.Forms.Label();
            this.lblControlEmail = new System.Windows.Forms.Label();
            this.lblControlPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPersonalInfoCheck = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUserGender = new System.Windows.Forms.ComboBox();
            this.nudUserHeight = new System.Windows.Forms.NumericUpDown();
            this.nudUserWeight = new System.Windows.Forms.NumericUpDown();
            this.dtpUserBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtUserSurname = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserWeight)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblControlConfirm
            // 
            this.lblControlConfirm.Location = new System.Drawing.Point(98, 217);
            this.lblControlConfirm.Name = "lblControlConfirm";
            this.lblControlConfirm.Size = new System.Drawing.Size(369, 16);
            this.lblControlConfirm.TabIndex = 19;
            this.lblControlConfirm.Text = "Confirm Control";
            this.lblControlConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblControlConfirm.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegister.Location = new System.Drawing.Point(183, 452);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(90, 23);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(101, 194);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(366, 20);
            this.txtConfirmPassword.TabIndex = 17;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(101, 81);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(251, 20);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(101, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(366, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email";
            // 
            // lblControlTotalPwd
            // 
            this.lblControlTotalPwd.AutoSize = true;
            this.lblControlTotalPwd.ForeColor = System.Drawing.Color.Red;
            this.lblControlTotalPwd.Location = new System.Drawing.Point(98, 249);
            this.lblControlTotalPwd.Name = "lblControlTotalPwd";
            this.lblControlTotalPwd.Size = new System.Drawing.Size(310, 26);
            this.lblControlTotalPwd.TabIndex = 20;
            this.lblControlTotalPwd.Text = "Please choose a stronger password.\r\nTry a mix of upper and lower case letters, nu" +
    "mbers, and symbols.";
            this.lblControlTotalPwd.Visible = false;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(365, 84);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(102, 17);
            this.chkShowPassword.TabIndex = 21;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // lblPC1
            // 
            this.lblPC1.AutoSize = true;
            this.lblPC1.ForeColor = System.Drawing.Color.Silver;
            this.lblPC1.Location = new System.Drawing.Point(98, 123);
            this.lblPC1.Name = "lblPC1";
            this.lblPC1.Size = new System.Drawing.Size(225, 13);
            this.lblPC1.TabIndex = 23;
            this.lblPC1.Text = "The password must have at least 8 characters";
            // 
            // lblPC2
            // 
            this.lblPC2.AutoSize = true;
            this.lblPC2.ForeColor = System.Drawing.Color.Silver;
            this.lblPC2.Location = new System.Drawing.Point(98, 136);
            this.lblPC2.Name = "lblPC2";
            this.lblPC2.Size = new System.Drawing.Size(252, 13);
            this.lblPC2.TabIndex = 24;
            this.lblPC2.Text = "The password must have at least 1 lower case letter";
            // 
            // lblPC3
            // 
            this.lblPC3.AutoSize = true;
            this.lblPC3.ForeColor = System.Drawing.Color.Silver;
            this.lblPC3.Location = new System.Drawing.Point(98, 149);
            this.lblPC3.Name = "lblPC3";
            this.lblPC3.Size = new System.Drawing.Size(254, 13);
            this.lblPC3.TabIndex = 25;
            this.lblPC3.Text = "The password must have at least 1 upper case letter";
            // 
            // lblPC4
            // 
            this.lblPC4.AutoSize = true;
            this.lblPC4.ForeColor = System.Drawing.Color.Silver;
            this.lblPC4.Location = new System.Drawing.Point(98, 162);
            this.lblPC4.Name = "lblPC4";
            this.lblPC4.Size = new System.Drawing.Size(210, 13);
            this.lblPC4.TabIndex = 26;
            this.lblPC4.Text = "The password must have at least 1 number";
            // 
            // lblPC5
            // 
            this.lblPC5.AutoSize = true;
            this.lblPC5.ForeColor = System.Drawing.Color.Silver;
            this.lblPC5.Location = new System.Drawing.Point(98, 175);
            this.lblPC5.Name = "lblPC5";
            this.lblPC5.Size = new System.Drawing.Size(369, 13);
            this.lblPC5.TabIndex = 27;
            this.lblPC5.Text = "The password must have at least 1 special character, excluding !@#/+%^-&*()";
            // 
            // lblControlEmail
            // 
            this.lblControlEmail.Location = new System.Drawing.Point(98, 61);
            this.lblControlEmail.Name = "lblControlEmail";
            this.lblControlEmail.Size = new System.Drawing.Size(369, 16);
            this.lblControlEmail.TabIndex = 28;
            this.lblControlEmail.Text = "Email Control";
            this.lblControlEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblControlEmail.Visible = false;
            // 
            // lblControlPassword
            // 
            this.lblControlPassword.Location = new System.Drawing.Point(98, 104);
            this.lblControlPassword.Name = "lblControlPassword";
            this.lblControlPassword.Size = new System.Drawing.Size(369, 16);
            this.lblControlPassword.TabIndex = 29;
            this.lblControlPassword.Text = "Password Control";
            this.lblControlPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblControlPassword.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.Location = new System.Drawing.Point(5, 452);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 23);
            this.btnLogin.TabIndex = 30;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblPersonalInfoCheck);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbUserGender);
            this.groupBox1.Controls.Add(this.nudUserHeight);
            this.groupBox1.Controls.Add(this.nudUserWeight);
            this.groupBox1.Controls.Add(this.dtpUserBirthDate);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.txtUserSurname);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Location = new System.Drawing.Point(482, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 481);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // lblPersonalInfoCheck
            // 
            this.lblPersonalInfoCheck.AutoSize = true;
            this.lblPersonalInfoCheck.ForeColor = System.Drawing.Color.Orange;
            this.lblPersonalInfoCheck.Location = new System.Drawing.Point(64, 322);
            this.lblPersonalInfoCheck.Name = "lblPersonalInfoCheck";
            this.lblPersonalInfoCheck.Size = new System.Drawing.Size(149, 13);
            this.lblPersonalInfoCheck.TabIndex = 19;
            this.lblPersonalInfoCheck.Text = "These fields cannot be empty!";
            this.lblPersonalInfoCheck.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Weight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Birth Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // cmbUserGender
            // 
            this.cmbUserGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserGender.FormattingEnabled = true;
            this.cmbUserGender.Location = new System.Drawing.Point(67, 276);
            this.cmbUserGender.Name = "cmbUserGender";
            this.cmbUserGender.Size = new System.Drawing.Size(200, 21);
            this.cmbUserGender.TabIndex = 5;
            // 
            // nudUserHeight
            // 
            this.nudUserHeight.Location = new System.Drawing.Point(67, 228);
            this.nudUserHeight.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudUserHeight.Name = "nudUserHeight";
            this.nudUserHeight.Size = new System.Drawing.Size(200, 20);
            this.nudUserHeight.TabIndex = 4;
            this.nudUserHeight.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // nudUserWeight
            // 
            this.nudUserWeight.DecimalPlaces = 2;
            this.nudUserWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudUserWeight.Location = new System.Drawing.Point(67, 180);
            this.nudUserWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudUserWeight.Name = "nudUserWeight";
            this.nudUserWeight.Size = new System.Drawing.Size(200, 20);
            this.nudUserWeight.TabIndex = 3;
            this.nudUserWeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // dtpUserBirthDate
            // 
            this.dtpUserBirthDate.Location = new System.Drawing.Point(67, 132);
            this.dtpUserBirthDate.Name = "dtpUserBirthDate";
            this.dtpUserBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpUserBirthDate.TabIndex = 2;
            // 
            // txtUserSurname
            // 
            this.txtUserSurname.Location = new System.Drawing.Point(67, 84);
            this.txtUserSurname.Name = "txtUserSurname";
            this.txtUserSurname.Size = new System.Drawing.Size(200, 20);
            this.txtUserSurname.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(67, 36);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.btnLogin);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblControlPassword);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.lblControlEmail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblPC5);
            this.groupBox2.Controls.Add(this.txtConfirmPassword);
            this.groupBox2.Controls.Add(this.lblPC4);
            this.groupBox2.Controls.Add(this.lblPC3);
            this.groupBox2.Controls.Add(this.lblControlConfirm);
            this.groupBox2.Controls.Add(this.lblPC2);
            this.groupBox2.Controls.Add(this.lblControlTotalPwd);
            this.groupBox2.Controls.Add(this.lblPC1);
            this.groupBox2.Controls.Add(this.chkShowPassword);
            this.groupBox2.Location = new System.Drawing.Point(3, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 481);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Register";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 505);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
           // this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserWeight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblControlConfirm;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblControlTotalPwd;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lblPC1;
        private System.Windows.Forms.Label lblPC2;
        private System.Windows.Forms.Label lblPC3;
        private System.Windows.Forms.Label lblPC4;
        private System.Windows.Forms.Label lblPC5;
        private System.Windows.Forms.Label lblControlEmail;
        private System.Windows.Forms.Label lblControlPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUserGender;
        private System.Windows.Forms.NumericUpDown nudUserHeight;
        private System.Windows.Forms.NumericUpDown nudUserWeight;
        private System.Windows.Forms.DateTimePicker dtpUserBirthDate;
        private System.Windows.Forms.TextBox txtUserSurname;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPersonalInfoCheck;
    }
}