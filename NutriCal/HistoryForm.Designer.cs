
namespace NutriCal
{
    partial class HistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDinner = new System.Windows.Forms.Label();
            this.lblAfternoonSnack = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.lblMorningSnack = new System.Windows.Forms.Label();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbByMeal = new System.Windows.Forms.ComboBox();
            this.gbByFood = new System.Windows.Forms.GroupBox();
            this.rbCategory = new System.Windows.Forms.RadioButton();
            this.rbMeal = new System.Windows.Forms.RadioButton();
            this.gbMeals = new System.Windows.Forms.GroupBox();
            this.dgvXXX = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBy = new System.Windows.Forms.ComboBox();
            this.cmbTimeInt = new System.Windows.Forms.ComboBox();
            this.cmbByCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            this.gbDate.SuspendLayout();
            this.gbByFood.SuspendLayout();
            this.gbMeals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXXX)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFoods
            // 
            this.dgvFoods.AllowUserToAddRows = false;
            this.dgvFoods.AllowUserToDeleteRows = false;
            this.dgvFoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoods.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Location = new System.Drawing.Point(9, 114);
            this.dgvFoods.Margin = new System.Windows.Forms.Padding(6);
            this.dgvFoods.MultiSelect = false;
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.ReadOnly = true;
            this.dgvFoods.RowHeadersVisible = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvFoods.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoods.Size = new System.Drawing.Size(291, 361);
            this.dgvFoods.TabIndex = 10;
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.lblTotalCalories);
            this.gbDate.Controls.Add(this.label8);
            this.gbDate.Controls.Add(this.lblUser);
            this.gbDate.Controls.Add(this.lblDinner);
            this.gbDate.Controls.Add(this.lblAfternoonSnack);
            this.gbDate.Controls.Add(this.lblLunch);
            this.gbDate.Controls.Add(this.lblMorningSnack);
            this.gbDate.Controls.Add(this.lblBreakfast);
            this.gbDate.Controls.Add(this.label5);
            this.gbDate.Controls.Add(this.label4);
            this.gbDate.Controls.Add(this.label3);
            this.gbDate.Controls.Add(this.label2);
            this.gbDate.Controls.Add(this.label1);
            this.gbDate.Location = new System.Drawing.Point(12, 12);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(193, 489);
            this.gbDate.TabIndex = 11;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Date";
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Location = new System.Drawing.Point(109, 462);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(41, 13);
            this.lblTotalCalories.TabIndex = 14;
            this.lblTotalCalories.Text = "label10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total Calories:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(6, 40);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "User";
            // 
            // lblDinner
            // 
            this.lblDinner.AutoSize = true;
            this.lblDinner.Location = new System.Drawing.Point(109, 274);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(41, 13);
            this.lblDinner.TabIndex = 9;
            this.lblDinner.Text = "label10";
            // 
            // lblAfternoonSnack
            // 
            this.lblAfternoonSnack.AutoSize = true;
            this.lblAfternoonSnack.Location = new System.Drawing.Point(109, 244);
            this.lblAfternoonSnack.Name = "lblAfternoonSnack";
            this.lblAfternoonSnack.Size = new System.Drawing.Size(35, 13);
            this.lblAfternoonSnack.TabIndex = 8;
            this.lblAfternoonSnack.Text = "label9";
            // 
            // lblLunch
            // 
            this.lblLunch.AutoSize = true;
            this.lblLunch.Location = new System.Drawing.Point(109, 214);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(35, 13);
            this.lblLunch.TabIndex = 7;
            this.lblLunch.Text = "label8";
            // 
            // lblMorningSnack
            // 
            this.lblMorningSnack.AutoSize = true;
            this.lblMorningSnack.Location = new System.Drawing.Point(109, 184);
            this.lblMorningSnack.Name = "lblMorningSnack";
            this.lblMorningSnack.Size = new System.Drawing.Size(35, 13);
            this.lblMorningSnack.TabIndex = 6;
            this.lblMorningSnack.Text = "label7";
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.Location = new System.Drawing.Point(109, 154);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(35, 13);
            this.lblBreakfast.TabIndex = 5;
            this.lblBreakfast.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dinner:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Afternoon Snack:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lunch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Morning Snack:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Breakfast:";
            // 
            // cmbByMeal
            // 
            this.cmbByMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbByMeal.Enabled = false;
            this.cmbByMeal.FormattingEnabled = true;
            this.cmbByMeal.Location = new System.Drawing.Point(9, 84);
            this.cmbByMeal.Name = "cmbByMeal";
            this.cmbByMeal.Size = new System.Drawing.Size(135, 21);
            this.cmbByMeal.TabIndex = 10;
            this.cmbByMeal.SelectedIndexChanged += new System.EventHandler(this.cmbMeals_SelectedIndexChanged);
            // 
            // gbByFood
            // 
            this.gbByFood.Controls.Add(this.cmbByCategory);
            this.gbByFood.Controls.Add(this.rbCategory);
            this.gbByFood.Controls.Add(this.rbMeal);
            this.gbByFood.Controls.Add(this.cmbByMeal);
            this.gbByFood.Controls.Add(this.dgvFoods);
            this.gbByFood.Location = new System.Drawing.Point(236, 12);
            this.gbByFood.Name = "gbByFood";
            this.gbByFood.Size = new System.Drawing.Size(316, 489);
            this.gbByFood.TabIndex = 12;
            this.gbByFood.TabStop = false;
            this.gbByFood.Text = "Foods";
            // 
            // rbCategory
            // 
            this.rbCategory.AutoSize = true;
            this.rbCategory.Location = new System.Drawing.Point(177, 40);
            this.rbCategory.Name = "rbCategory";
            this.rbCategory.Size = new System.Drawing.Size(100, 17);
            this.rbCategory.TabIndex = 13;
            this.rbCategory.TabStop = true;
            this.rbCategory.Text = "List by Category";
            this.rbCategory.UseVisualStyleBackColor = true;
            this.rbCategory.Click += new System.EventHandler(this.rbCategory_Click);
            // 
            // rbMeal
            // 
            this.rbMeal.AutoSize = true;
            this.rbMeal.Checked = true;
            this.rbMeal.Location = new System.Drawing.Point(39, 40);
            this.rbMeal.Name = "rbMeal";
            this.rbMeal.Size = new System.Drawing.Size(81, 17);
            this.rbMeal.TabIndex = 12;
            this.rbMeal.TabStop = true;
            this.rbMeal.Text = "List by Meal";
            this.rbMeal.UseVisualStyleBackColor = true;
            this.rbMeal.Click += new System.EventHandler(this.rbMeal_Click);
            // 
            // gbMeals
            // 
            this.gbMeals.Controls.Add(this.dgvXXX);
            this.gbMeals.Controls.Add(this.label9);
            this.gbMeals.Controls.Add(this.label7);
            this.gbMeals.Controls.Add(this.cmbBy);
            this.gbMeals.Controls.Add(this.cmbTimeInt);
            this.gbMeals.Location = new System.Drawing.Point(571, 12);
            this.gbMeals.Name = "gbMeals";
            this.gbMeals.Size = new System.Drawing.Size(311, 489);
            this.gbMeals.TabIndex = 13;
            this.gbMeals.TabStop = false;
            this.gbMeals.Text = "Meals";
            // 
            // dgvXXX
            // 
            this.dgvXXX.AllowUserToAddRows = false;
            this.dgvXXX.AllowUserToDeleteRows = false;
            this.dgvXXX.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvXXX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXXX.Location = new System.Drawing.Point(9, 84);
            this.dgvXXX.Margin = new System.Windows.Forms.Padding(6);
            this.dgvXXX.MultiSelect = false;
            this.dgvXXX.Name = "dgvXXX";
            this.dgvXXX.ReadOnly = true;
            this.dgvXXX.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvXXX.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvXXX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXXX.Size = new System.Drawing.Size(306, 391);
            this.dgvXXX.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "By What?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Time Interval";
            // 
            // cmbBy
            // 
            this.cmbBy.FormattingEnabled = true;
            this.cmbBy.Items.AddRange(new object[] {
            "By Meal",
            "By Food Categories"});
            this.cmbBy.Location = new System.Drawing.Point(182, 54);
            this.cmbBy.Name = "cmbBy";
            this.cmbBy.Size = new System.Drawing.Size(123, 21);
            this.cmbBy.TabIndex = 12;
            // 
            // cmbTimeInt
            // 
            this.cmbTimeInt.FormattingEnabled = true;
            this.cmbTimeInt.Items.AddRange(new object[] {
            "Last 1 Week",
            "Last 1 Month"});
            this.cmbTimeInt.Location = new System.Drawing.Point(9, 54);
            this.cmbTimeInt.Name = "cmbTimeInt";
            this.cmbTimeInt.Size = new System.Drawing.Size(120, 21);
            this.cmbTimeInt.TabIndex = 11;
            // 
            // cmbByCategory
            // 
            this.cmbByCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbByCategory.Enabled = false;
            this.cmbByCategory.FormattingEnabled = true;
            this.cmbByCategory.Location = new System.Drawing.Point(161, 84);
            this.cmbByCategory.Name = "cmbByCategory";
            this.cmbByCategory.Size = new System.Drawing.Size(139, 21);
            this.cmbByCategory.TabIndex = 14;
            this.cmbByCategory.SelectedIndexChanged += new System.EventHandler(this.cmbByCategory_SelectedIndexChanged);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 513);
            this.Controls.Add(this.gbMeals);
            this.Controls.Add(this.gbByFood);
            this.Controls.Add(this.gbDate);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            this.gbByFood.ResumeLayout(false);
            this.gbByFood.PerformLayout();
            this.gbMeals.ResumeLayout(false);
            this.gbMeals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXXX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFoods;
        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.Label lblAfternoonSnack;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.Label lblMorningSnack;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.ComboBox cmbByMeal;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox gbByFood;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbMeals;
        private System.Windows.Forms.ComboBox cmbBy;
        private System.Windows.Forms.ComboBox cmbTimeInt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvXXX;
        private System.Windows.Forms.RadioButton rbCategory;
        private System.Windows.Forms.RadioButton rbMeal;
        private System.Windows.Forms.ComboBox cmbByCategory;
    }
}