namespace NutriCal
{
    partial class FoodsForm
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
            this.lblMealName = new System.Windows.Forms.Label();
            this.cboFoods = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pboSelectedMeal = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFoodCategories = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nudPorsion = new System.Windows.Forms.NumericUpDown();
            this.lblPorsion = new System.Windows.Forms.Label();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.FoodCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porsion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodCalories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pboSelectedMeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMealName
            // 
            this.lblMealName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMealName.AutoSize = true;
            this.lblMealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblMealName.Location = new System.Drawing.Point(219, 9);
            this.lblMealName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMealName.Name = "lblMealName";
            this.lblMealName.Size = new System.Drawing.Size(139, 29);
            this.lblMealName.TabIndex = 0;
            this.lblMealName.Text = "MealName";
            // 
            // cboFoods
            // 
            this.cboFoods.BackColor = System.Drawing.Color.OliveDrab;
            this.cboFoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboFoods.FormattingEnabled = true;
            this.cboFoods.Location = new System.Drawing.Point(28, 249);
            this.cboFoods.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cboFoods.Name = "cboFoods";
            this.cboFoods.Size = new System.Drawing.Size(262, 28);
            this.cboFoods.TabIndex = 2;
            this.cboFoods.SelectedIndexChanged += new System.EventHandler(this.cboFoods_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(505, 209);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 68);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD FOOD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pboSelectedMeal
            // 
            this.pboSelectedMeal.Location = new System.Drawing.Point(222, 57);
            this.pboSelectedMeal.Name = "pboSelectedMeal";
            this.pboSelectedMeal.Size = new System.Drawing.Size(152, 104);
            this.pboSelectedMeal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboSelectedMeal.TabIndex = 5;
            this.pboSelectedMeal.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(89, 299);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(473, 26);
            this.txtSearch.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(24, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search:";
            // 
            // cboFoodCategories
            // 
            this.cboFoodCategories.BackColor = System.Drawing.Color.OliveDrab;
            this.cboFoodCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoodCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboFoodCategories.FormattingEnabled = true;
            this.cboFoodCategories.Location = new System.Drawing.Point(28, 209);
            this.cboFoodCategories.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cboFoodCategories.Name = "cboFoodCategories";
            this.cboFoodCategories.Size = new System.Drawing.Size(262, 28);
            this.cboFoodCategories.TabIndex = 1;
            this.cboFoodCategories.SelectedIndexChanged += new System.EventHandler(this.cboFoodCategories_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(487, 650);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "SAVE MEAL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nudPorsion
            // 
            this.nudPorsion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudPorsion.Location = new System.Drawing.Point(284, 251);
            this.nudPorsion.Name = "nudPorsion";
            this.nudPorsion.Size = new System.Drawing.Size(81, 26);
            this.nudPorsion.TabIndex = 4;
            this.nudPorsion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPorsion.ValueChanged += new System.EventHandler(this.nudPorsion_ValueChanged);
            // 
            // lblPorsion
            // 
            this.lblPorsion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPorsion.AutoSize = true;
            this.lblPorsion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPorsion.Location = new System.Drawing.Point(280, 210);
            this.lblPorsion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPorsion.Name = "lblPorsion";
            this.lblPorsion.Size = new System.Drawing.Size(91, 24);
            this.lblPorsion.TabIndex = 3;
            this.lblPorsion.Text = "Porsions";
            // 
            // dgvFood
            // 
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodCategory,
            this.FoodName,
            this.Porsion,
            this.FoodCalories});
            this.dgvFood.Location = new System.Drawing.Point(28, 338);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.Size = new System.Drawing.Size(535, 304);
            this.dgvFood.TabIndex = 10;
            // 
            // FoodCategory
            // 
            this.FoodCategory.DataPropertyName = "CategoryName";
            this.FoodCategory.HeaderText = "Category";
            this.FoodCategory.Name = "FoodCategory";
            // 
            // FoodName
            // 
            this.FoodName.DataPropertyName = "FoodName";
            this.FoodName.HeaderText = "Name";
            this.FoodName.Name = "FoodName";
            // 
            // Porsion
            // 
            this.Porsion.DataPropertyName = "Porsion";
            this.Porsion.HeaderText = "Porsion";
            this.Porsion.Name = "Porsion";
            // 
            // FoodCalories
            // 
            this.FoodCalories.DataPropertyName = "TotalCalory";
            this.FoodCalories.HeaderText = "Calories";
            this.FoodCalories.Name = "FoodCalories";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(615, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 310);
            this.dataGridView1.TabIndex = 11;
            // 
            // FoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 710);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.lblPorsion);
            this.Controls.Add(this.nudPorsion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboFoodCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pboSelectedMeal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboFoods);
            this.Controls.Add(this.lblMealName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FoodsForm";
            this.Text = "FoodsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pboSelectedMeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMealName;
        private System.Windows.Forms.ComboBox cboFoods;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pboSelectedMeal;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFoodCategories;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudPorsion;
        private System.Windows.Forms.Label lblPorsion;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porsion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodCalories;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}