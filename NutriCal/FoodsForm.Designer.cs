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
            this.cboFoodCategories = new System.Windows.Forms.ComboBox();
            this.btnSaveMeal = new System.Windows.Forms.Button();
            this.nudPorsion = new System.Windows.Forms.NumericUpDown();
            this.lblPorsion = new System.Windows.Forms.Label();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.btnAddCustom = new System.Windows.Forms.Button();
            this.lblFood = new System.Windows.Forms.Label();
            this.pboFood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboSelectedMeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFood)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMealName
            // 
            this.lblMealName.AutoSize = true;
            this.lblMealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblMealName.Location = new System.Drawing.Point(515, 18);
            this.lblMealName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMealName.Name = "lblMealName";
            this.lblMealName.Size = new System.Drawing.Size(139, 29);
            this.lblMealName.TabIndex = 0;
            this.lblMealName.Text = "MealName";
            this.lblMealName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnAdd.Location = new System.Drawing.Point(480, 195);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 82);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Food";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pboSelectedMeal
            // 
            this.pboSelectedMeal.Location = new System.Drawing.Point(502, 61);
            this.pboSelectedMeal.Name = "pboSelectedMeal";
            this.pboSelectedMeal.Size = new System.Drawing.Size(152, 104);
            this.pboSelectedMeal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboSelectedMeal.TabIndex = 5;
            this.pboSelectedMeal.TabStop = false;
            // 
            // cboFoodCategories
            // 
            this.cboFoodCategories.BackColor = System.Drawing.Color.OliveDrab;
            this.cboFoodCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoodCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboFoodCategories.FormattingEnabled = true;
            this.cboFoodCategories.Location = new System.Drawing.Point(28, 195);
            this.cboFoodCategories.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cboFoodCategories.Name = "cboFoodCategories";
            this.cboFoodCategories.Size = new System.Drawing.Size(262, 28);
            this.cboFoodCategories.TabIndex = 1;
            this.cboFoodCategories.SelectedIndexChanged += new System.EventHandler(this.cboFoodCategories_SelectedIndexChanged);
            // 
            // btnSaveMeal
            // 
            this.btnSaveMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveMeal.Location = new System.Drawing.Point(556, 653);
            this.btnSaveMeal.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSaveMeal.Name = "btnSaveMeal";
            this.btnSaveMeal.Size = new System.Drawing.Size(98, 43);
            this.btnSaveMeal.TabIndex = 8;
            this.btnSaveMeal.Text = "Save Meal";
            this.btnSaveMeal.UseVisualStyleBackColor = true;
            this.btnSaveMeal.Click += new System.EventHandler(this.btnSaveMeal_Click);
            // 
            // nudPorsion
            // 
            this.nudPorsion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudPorsion.Location = new System.Drawing.Point(306, 250);
            this.nudPorsion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPorsion.Name = "nudPorsion";
            this.nudPorsion.Size = new System.Drawing.Size(81, 26);
            this.nudPorsion.TabIndex = 4;
            this.nudPorsion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPorsion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPorsion
            // 
            this.lblPorsion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPorsion.AutoSize = true;
            this.lblPorsion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPorsion.Location = new System.Drawing.Point(302, 195);
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
            this.dgvFood.Location = new System.Drawing.Point(28, 285);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.Size = new System.Drawing.Size(626, 357);
            this.dgvFood.TabIndex = 11;
            // 
            // btnAddCustom
            // 
            this.btnAddCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCustom.Location = new System.Drawing.Point(571, 195);
            this.btnAddCustom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAddCustom.Name = "btnAddCustom";
            this.btnAddCustom.Size = new System.Drawing.Size(83, 82);
            this.btnAddCustom.TabIndex = 12;
            this.btnAddCustom.Text = "Add Custom Food";
            this.btnAddCustom.UseVisualStyleBackColor = true;
            this.btnAddCustom.Click += new System.EventHandler(this.btnAddCustom_Click);
            // 
            // lblFood
            // 
            this.lblFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblFood.Location = new System.Drawing.Point(23, 18);
            this.lblFood.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(74, 29);
            this.lblFood.TabIndex = 13;
            this.lblFood.Text = "Food";
            // 
            // pboFood
            // 
            this.pboFood.Location = new System.Drawing.Point(23, 61);
            this.pboFood.Name = "pboFood";
            this.pboFood.Size = new System.Drawing.Size(152, 104);
            this.pboFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboFood.TabIndex = 14;
            this.pboFood.TabStop = false;
            // 
            // FoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 710);
            this.Controls.Add(this.pboFood);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.btnAddCustom);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.lblPorsion);
            this.Controls.Add(this.nudPorsion);
            this.Controls.Add(this.btnSaveMeal);
            this.Controls.Add(this.cboFoodCategories);
            this.Controls.Add(this.pboSelectedMeal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboFoods);
            this.Controls.Add(this.lblMealName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FoodsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pboSelectedMeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMealName;
        private System.Windows.Forms.ComboBox cboFoods;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pboSelectedMeal;
        private System.Windows.Forms.ComboBox cboFoodCategories;
        private System.Windows.Forms.Button btnSaveMeal;
        private System.Windows.Forms.NumericUpDown nudPorsion;
        private System.Windows.Forms.Label lblPorsion;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Button btnAddCustom;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.PictureBox pboFood;
    }
}