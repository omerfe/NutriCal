
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
            if (disposing)
            {
                db.Dispose();
            }
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.lblMorningSnack = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.lblDinner = new System.Windows.Forms.Label();
            this.lblAfternoonSnack = new System.Windows.Forms.Label();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbByMeal = new System.Windows.Forms.ComboBox();
            this.gbByFood = new System.Windows.Forms.GroupBox();
            this.cmbByCategory = new System.Windows.Forms.ComboBox();
            this.rbCategory = new System.Windows.Forms.RadioButton();
            this.rbMeal = new System.Windows.Forms.RadioButton();
            this.gbMeals = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbUserAvg = new System.Windows.Forms.GroupBox();
            this.lblUserBreakfast = new System.Windows.Forms.Label();
            this.lblUserMSnack = new System.Windows.Forms.Label();
            this.lblUserDinner = new System.Windows.Forms.Label();
            this.lblUserLunch = new System.Windows.Forms.Label();
            this.lblUserASnack = new System.Windows.Forms.Label();
            this.gbTotalAvg = new System.Windows.Forms.GroupBox();
            this.lblTotalBreakfast = new System.Windows.Forms.Label();
            this.lblTotalMSnack = new System.Windows.Forms.Label();
            this.lblTotalLunch = new System.Windows.Forms.Label();
            this.lblTotalASnack = new System.Windows.Forms.Label();
            this.lblTotalDinner = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTimeInt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            this.gbDate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbByFood.SuspendLayout();
            this.gbMeals.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbUserAvg.SuspendLayout();
            this.gbTotalAvg.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFoods
            // 
            this.dgvFoods.AllowUserToAddRows = false;
            this.dgvFoods.AllowUserToDeleteRows = false;
            this.dgvFoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoods.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Location = new System.Drawing.Point(13, 164);
            this.dgvFoods.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.dgvFoods.MultiSelect = false;
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.ReadOnly = true;
            this.dgvFoods.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvFoods.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoods.Size = new System.Drawing.Size(471, 445);
            this.dgvFoods.TabIndex = 10;
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.groupBox2);
            this.gbDate.Controls.Add(this.groupBox1);
            this.gbDate.Controls.Add(this.lblTotalCalories);
            this.gbDate.Controls.Add(this.label8);
            this.gbDate.Controls.Add(this.lblUser);
            this.gbDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbDate.Location = new System.Drawing.Point(13, 4);
            this.gbDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDate.Name = "gbDate";
            this.gbDate.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDate.Size = new System.Drawing.Size(304, 661);
            this.gbDate.TabIndex = 11;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(8, 164);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(152, 307);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Breakfast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Morning Snack";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lunch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Afternoon Snack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dinner";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBreakfast);
            this.groupBox1.Controls.Add(this.lblMorningSnack);
            this.groupBox1.Controls.Add(this.lblLunch);
            this.groupBox1.Controls.Add(this.lblDinner);
            this.groupBox1.Controls.Add(this.lblAfternoonSnack);
            this.groupBox1.Location = new System.Drawing.Point(168, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(126, 307);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calories";
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.Location = new System.Drawing.Point(9, 63);
            this.lblBreakfast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(54, 21);
            this.lblBreakfast.TabIndex = 5;
            this.lblBreakfast.Text = "0 kcal";
            // 
            // lblMorningSnack
            // 
            this.lblMorningSnack.AutoSize = true;
            this.lblMorningSnack.Location = new System.Drawing.Point(9, 111);
            this.lblMorningSnack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMorningSnack.Name = "lblMorningSnack";
            this.lblMorningSnack.Size = new System.Drawing.Size(54, 21);
            this.lblMorningSnack.TabIndex = 6;
            this.lblMorningSnack.Text = "0 kcal";
            // 
            // lblLunch
            // 
            this.lblLunch.AutoSize = true;
            this.lblLunch.Location = new System.Drawing.Point(9, 160);
            this.lblLunch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(54, 21);
            this.lblLunch.TabIndex = 7;
            this.lblLunch.Text = "0 kcal";
            // 
            // lblDinner
            // 
            this.lblDinner.AutoSize = true;
            this.lblDinner.Location = new System.Drawing.Point(9, 257);
            this.lblDinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(54, 21);
            this.lblDinner.TabIndex = 9;
            this.lblDinner.Text = "0 kcal";
            // 
            // lblAfternoonSnack
            // 
            this.lblAfternoonSnack.AutoSize = true;
            this.lblAfternoonSnack.Location = new System.Drawing.Point(9, 208);
            this.lblAfternoonSnack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAfternoonSnack.Name = "lblAfternoonSnack";
            this.lblAfternoonSnack.Size = new System.Drawing.Size(54, 21);
            this.lblAfternoonSnack.TabIndex = 8;
            this.lblAfternoonSnack.Text = "0 kcal";
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Location = new System.Drawing.Point(177, 541);
            this.lblTotalCalories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(54, 21);
            this.lblTotalCalories.TabIndex = 14;
            this.lblTotalCalories.Text = "0 kcal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 541);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total Calories:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(8, 67);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(44, 21);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "User";
            // 
            // cmbByMeal
            // 
            this.cmbByMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbByMeal.Enabled = false;
            this.cmbByMeal.FormattingEnabled = true;
            this.cmbByMeal.Location = new System.Drawing.Point(14, 120);
            this.cmbByMeal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbByMeal.Name = "cmbByMeal";
            this.cmbByMeal.Size = new System.Drawing.Size(200, 29);
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
            this.gbByFood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbByFood.Location = new System.Drawing.Point(340, 4);
            this.gbByFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbByFood.Name = "gbByFood";
            this.gbByFood.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbByFood.Size = new System.Drawing.Size(508, 658);
            this.gbByFood.TabIndex = 12;
            this.gbByFood.TabStop = false;
            this.gbByFood.Text = "Foods";
            // 
            // cmbByCategory
            // 
            this.cmbByCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbByCategory.Enabled = false;
            this.cmbByCategory.FormattingEnabled = true;
            this.cmbByCategory.Location = new System.Drawing.Point(278, 120);
            this.cmbByCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbByCategory.Name = "cmbByCategory";
            this.cmbByCategory.Size = new System.Drawing.Size(206, 29);
            this.cmbByCategory.TabIndex = 14;
            this.cmbByCategory.SelectedIndexChanged += new System.EventHandler(this.cmbByCategory_SelectedIndexChanged);
            // 
            // rbCategory
            // 
            this.rbCategory.AutoSize = true;
            this.rbCategory.Location = new System.Drawing.Point(300, 65);
            this.rbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbCategory.Name = "rbCategory";
            this.rbCategory.Size = new System.Drawing.Size(151, 25);
            this.rbCategory.TabIndex = 13;
            this.rbCategory.Text = "List by Category";
            this.rbCategory.UseVisualStyleBackColor = true;
            this.rbCategory.Click += new System.EventHandler(this.rbCategory_Click);
            // 
            // rbMeal
            // 
            this.rbMeal.AutoSize = true;
            this.rbMeal.Location = new System.Drawing.Point(45, 65);
            this.rbMeal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMeal.Name = "rbMeal";
            this.rbMeal.Size = new System.Drawing.Size(119, 25);
            this.rbMeal.TabIndex = 12;
            this.rbMeal.Text = "List by Meal";
            this.rbMeal.UseVisualStyleBackColor = true;
            this.rbMeal.Click += new System.EventHandler(this.rbMeal_Click);
            // 
            // gbMeals
            // 
            this.gbMeals.Controls.Add(this.groupBox3);
            this.gbMeals.Controls.Add(this.gbUserAvg);
            this.gbMeals.Controls.Add(this.gbTotalAvg);
            this.gbMeals.Controls.Add(this.label7);
            this.gbMeals.Controls.Add(this.cmbTimeInt);
            this.gbMeals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbMeals.Location = new System.Drawing.Point(872, 4);
            this.gbMeals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMeals.Name = "gbMeals";
            this.gbMeals.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMeals.Size = new System.Drawing.Size(476, 658);
            this.gbMeals.TabIndex = 13;
            this.gbMeals.TabStop = false;
            this.gbMeals.Text = "Meals";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(12, 212);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(144, 310);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Meal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Breakfast";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Morning Snack";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Lunch";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 208);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "Afternoon Snack";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 257);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Dinner";
            // 
            // gbUserAvg
            // 
            this.gbUserAvg.Controls.Add(this.lblUserBreakfast);
            this.gbUserAvg.Controls.Add(this.lblUserMSnack);
            this.gbUserAvg.Controls.Add(this.lblUserDinner);
            this.gbUserAvg.Controls.Add(this.lblUserLunch);
            this.gbUserAvg.Controls.Add(this.lblUserASnack);
            this.gbUserAvg.Location = new System.Drawing.Point(164, 212);
            this.gbUserAvg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbUserAvg.Name = "gbUserAvg";
            this.gbUserAvg.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbUserAvg.Size = new System.Drawing.Size(144, 310);
            this.gbUserAvg.TabIndex = 32;
            this.gbUserAvg.TabStop = false;
            this.gbUserAvg.Text = "User Average";
            // 
            // lblUserBreakfast
            // 
            this.lblUserBreakfast.AutoSize = true;
            this.lblUserBreakfast.Location = new System.Drawing.Point(9, 65);
            this.lblUserBreakfast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserBreakfast.Name = "lblUserBreakfast";
            this.lblUserBreakfast.Size = new System.Drawing.Size(54, 21);
            this.lblUserBreakfast.TabIndex = 19;
            this.lblUserBreakfast.Text = "0 kcal";
            // 
            // lblUserMSnack
            // 
            this.lblUserMSnack.AutoSize = true;
            this.lblUserMSnack.Location = new System.Drawing.Point(9, 113);
            this.lblUserMSnack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserMSnack.Name = "lblUserMSnack";
            this.lblUserMSnack.Size = new System.Drawing.Size(54, 21);
            this.lblUserMSnack.TabIndex = 20;
            this.lblUserMSnack.Text = "0 kcal";
            // 
            // lblUserDinner
            // 
            this.lblUserDinner.AutoSize = true;
            this.lblUserDinner.Location = new System.Drawing.Point(9, 258);
            this.lblUserDinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserDinner.Name = "lblUserDinner";
            this.lblUserDinner.Size = new System.Drawing.Size(54, 21);
            this.lblUserDinner.TabIndex = 23;
            this.lblUserDinner.Text = "0 kcal";
            // 
            // lblUserLunch
            // 
            this.lblUserLunch.AutoSize = true;
            this.lblUserLunch.Location = new System.Drawing.Point(9, 162);
            this.lblUserLunch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserLunch.Name = "lblUserLunch";
            this.lblUserLunch.Size = new System.Drawing.Size(54, 21);
            this.lblUserLunch.TabIndex = 21;
            this.lblUserLunch.Text = "0 kcal";
            // 
            // lblUserASnack
            // 
            this.lblUserASnack.AutoSize = true;
            this.lblUserASnack.Location = new System.Drawing.Point(9, 210);
            this.lblUserASnack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserASnack.Name = "lblUserASnack";
            this.lblUserASnack.Size = new System.Drawing.Size(54, 21);
            this.lblUserASnack.TabIndex = 22;
            this.lblUserASnack.Text = "0 kcal";
            // 
            // gbTotalAvg
            // 
            this.gbTotalAvg.Controls.Add(this.lblTotalBreakfast);
            this.gbTotalAvg.Controls.Add(this.lblTotalMSnack);
            this.gbTotalAvg.Controls.Add(this.lblTotalLunch);
            this.gbTotalAvg.Controls.Add(this.lblTotalASnack);
            this.gbTotalAvg.Controls.Add(this.lblTotalDinner);
            this.gbTotalAvg.Location = new System.Drawing.Point(318, 212);
            this.gbTotalAvg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTotalAvg.Name = "gbTotalAvg";
            this.gbTotalAvg.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTotalAvg.Size = new System.Drawing.Size(144, 310);
            this.gbTotalAvg.TabIndex = 31;
            this.gbTotalAvg.TabStop = false;
            this.gbTotalAvg.Text = "Total Average";
            // 
            // lblTotalBreakfast
            // 
            this.lblTotalBreakfast.AutoSize = true;
            this.lblTotalBreakfast.Location = new System.Drawing.Point(9, 63);
            this.lblTotalBreakfast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalBreakfast.Name = "lblTotalBreakfast";
            this.lblTotalBreakfast.Size = new System.Drawing.Size(54, 21);
            this.lblTotalBreakfast.TabIndex = 24;
            this.lblTotalBreakfast.Text = "0 kcal";
            // 
            // lblTotalMSnack
            // 
            this.lblTotalMSnack.AutoSize = true;
            this.lblTotalMSnack.Location = new System.Drawing.Point(9, 111);
            this.lblTotalMSnack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalMSnack.Name = "lblTotalMSnack";
            this.lblTotalMSnack.Size = new System.Drawing.Size(54, 21);
            this.lblTotalMSnack.TabIndex = 25;
            this.lblTotalMSnack.Text = "0 kcal";
            // 
            // lblTotalLunch
            // 
            this.lblTotalLunch.AutoSize = true;
            this.lblTotalLunch.Location = new System.Drawing.Point(9, 160);
            this.lblTotalLunch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLunch.Name = "lblTotalLunch";
            this.lblTotalLunch.Size = new System.Drawing.Size(54, 21);
            this.lblTotalLunch.TabIndex = 26;
            this.lblTotalLunch.Text = "0 kcal";
            // 
            // lblTotalASnack
            // 
            this.lblTotalASnack.AutoSize = true;
            this.lblTotalASnack.Location = new System.Drawing.Point(9, 208);
            this.lblTotalASnack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalASnack.Name = "lblTotalASnack";
            this.lblTotalASnack.Size = new System.Drawing.Size(54, 21);
            this.lblTotalASnack.TabIndex = 27;
            this.lblTotalASnack.Text = "0 kcal";
            // 
            // lblTotalDinner
            // 
            this.lblTotalDinner.AutoSize = true;
            this.lblTotalDinner.Location = new System.Drawing.Point(9, 257);
            this.lblTotalDinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDinner.Name = "lblTotalDinner";
            this.lblTotalDinner.Size = new System.Drawing.Size(54, 21);
            this.lblTotalDinner.TabIndex = 28;
            this.lblTotalDinner.Text = "0 kcal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Time Interval";
            // 
            // cmbTimeInt
            // 
            this.cmbTimeInt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeInt.FormattingEnabled = true;
            this.cmbTimeInt.Items.AddRange(new object[] {
            "Last 1 Week",
            "Last 1 Month"});
            this.cmbTimeInt.Location = new System.Drawing.Point(12, 120);
            this.cmbTimeInt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTimeInt.Name = "cmbTimeInt";
            this.cmbTimeInt.Size = new System.Drawing.Size(448, 29);
            this.cmbTimeInt.TabIndex = 11;
            this.cmbTimeInt.SelectedIndexChanged += new System.EventHandler(this.cmbTimeInt_SelectedIndexChanged);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 676);
            this.Controls.Add(this.gbMeals);
            this.Controls.Add(this.gbByFood);
            this.Controls.Add(this.gbDate);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbByFood.ResumeLayout(false);
            this.gbByFood.PerformLayout();
            this.gbMeals.ResumeLayout(false);
            this.gbMeals.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbUserAvg.ResumeLayout(false);
            this.gbUserAvg.PerformLayout();
            this.gbTotalAvg.ResumeLayout(false);
            this.gbTotalAvg.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbTimeInt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbCategory;
        private System.Windows.Forms.RadioButton rbMeal;
        private System.Windows.Forms.ComboBox cmbByCategory;
        private System.Windows.Forms.Label lblTotalDinner;
        private System.Windows.Forms.Label lblTotalASnack;
        private System.Windows.Forms.Label lblTotalLunch;
        private System.Windows.Forms.Label lblTotalMSnack;
        private System.Windows.Forms.Label lblTotalBreakfast;
        private System.Windows.Forms.Label lblUserDinner;
        private System.Windows.Forms.Label lblUserASnack;
        private System.Windows.Forms.Label lblUserLunch;
        private System.Windows.Forms.Label lblUserMSnack;
        private System.Windows.Forms.Label lblUserBreakfast;
        private System.Windows.Forms.GroupBox gbUserAvg;
        private System.Windows.Forms.GroupBox gbTotalAvg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}