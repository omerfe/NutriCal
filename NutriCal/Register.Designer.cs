
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
            this.SuspendLayout();
            // 
            // lblControlConfirm
            // 
            this.lblControlConfirm.Location = new System.Drawing.Point(137, 213);
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
            this.btnRegister.Location = new System.Drawing.Point(225, 295);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 23);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(140, 190);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(214, 20);
            this.txtConfirmPassword.TabIndex = 17;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(140, 77);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(214, 20);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 34);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email:";
            // 
            // lblControlTotalPwd
            // 
            this.lblControlTotalPwd.AutoSize = true;
            this.lblControlTotalPwd.ForeColor = System.Drawing.Color.Red;
            this.lblControlTotalPwd.Location = new System.Drawing.Point(137, 245);
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
            this.chkShowPassword.Location = new System.Drawing.Point(360, 80);
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
            this.lblPC1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPC1.Location = new System.Drawing.Point(137, 119);
            this.lblPC1.Name = "lblPC1";
            this.lblPC1.Size = new System.Drawing.Size(225, 13);
            this.lblPC1.TabIndex = 23;
            this.lblPC1.Text = "The password must have at least 8 characters";
            // 
            // lblPC2
            // 
            this.lblPC2.AutoSize = true;
            this.lblPC2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPC2.Location = new System.Drawing.Point(137, 132);
            this.lblPC2.Name = "lblPC2";
            this.lblPC2.Size = new System.Drawing.Size(252, 13);
            this.lblPC2.TabIndex = 24;
            this.lblPC2.Text = "The password must have at least 1 lower case letter";
            // 
            // lblPC3
            // 
            this.lblPC3.AutoSize = true;
            this.lblPC3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPC3.Location = new System.Drawing.Point(137, 145);
            this.lblPC3.Name = "lblPC3";
            this.lblPC3.Size = new System.Drawing.Size(254, 13);
            this.lblPC3.TabIndex = 25;
            this.lblPC3.Text = "The password must have at least 1 upper case letter";
            // 
            // lblPC4
            // 
            this.lblPC4.AutoSize = true;
            this.lblPC4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPC4.Location = new System.Drawing.Point(137, 158);
            this.lblPC4.Name = "lblPC4";
            this.lblPC4.Size = new System.Drawing.Size(210, 13);
            this.lblPC4.TabIndex = 26;
            this.lblPC4.Text = "The password must have at least 1 number";
            // 
            // lblPC5
            // 
            this.lblPC5.AutoSize = true;
            this.lblPC5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPC5.Location = new System.Drawing.Point(137, 171);
            this.lblPC5.Name = "lblPC5";
            this.lblPC5.Size = new System.Drawing.Size(369, 13);
            this.lblPC5.TabIndex = 27;
            this.lblPC5.Text = "The password must have at least 1 special character, excluding !@#/+%^-&*()";
            // 
            // lblControlEmail
            // 
            this.lblControlEmail.Location = new System.Drawing.Point(137, 57);
            this.lblControlEmail.Name = "lblControlEmail";
            this.lblControlEmail.Size = new System.Drawing.Size(369, 16);
            this.lblControlEmail.TabIndex = 28;
            this.lblControlEmail.Text = "Email Control";
            this.lblControlEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblControlEmail.Visible = false;
            // 
            // lblControlPassword
            // 
            this.lblControlPassword.Location = new System.Drawing.Point(137, 100);
            this.lblControlPassword.Name = "lblControlPassword";
            this.lblControlPassword.Size = new System.Drawing.Size(369, 16);
            this.lblControlPassword.TabIndex = 29;
            this.lblControlPassword.Text = "Password Control";
            this.lblControlPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblControlPassword.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 332);
            this.Controls.Add(this.lblControlPassword);
            this.Controls.Add(this.lblControlEmail);
            this.Controls.Add(this.lblPC5);
            this.Controls.Add(this.lblPC4);
            this.Controls.Add(this.lblPC3);
            this.Controls.Add(this.lblPC2);
            this.Controls.Add(this.lblPC1);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.lblControlTotalPwd);
            this.Controls.Add(this.lblControlConfirm);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}