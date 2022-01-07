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
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.nudPorsion = new System.Windows.Forms.NumericUpDown();
            this.lblPorsion = new System.Windows.Forms.Label();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.btnAddCustom = new System.Windows.Forms.Button();
            this.lblFood = new System.Windows.Forms.Label();
            this.pboFood = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboSelectedMeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFood)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMealName
            // 
            this.lblMealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblMealName.Location = new System.Drawing.Point(508, 18);
            this.lblMealName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMealName.Name = "lblMealName";
            this.lblMealName.Size = new System.Drawing.Size(203, 29);
            this.lblMealName.TabIndex = 0;
            this.lblMealName.Text = "Afternoon Snack";
            this.lblMealName.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.btnAdd.Location = new System.Drawing.Point(446, 195);
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
            this.pboSelectedMeal.Location = new System.Drawing.Point(577, 50);
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
            // btnUpdateFood
            // 
            this.btnUpdateFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateFood.Location = new System.Drawing.Point(613, 653);
            this.btnUpdateFood.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(98, 43);
            this.btnUpdateFood.TabIndex = 8;
            this.btnUpdateFood.Text = "Update Food";
            this.btnUpdateFood.UseVisualStyleBackColor = true;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // nudPorsion
            // 
            this.nudPorsion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudPorsion.Location = new System.Drawing.Point(306, 248);
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
            this.lblPorsion.Location = new System.Drawing.Point(302, 193);
            this.lblPorsion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPorsion.Name = "lblPorsion";
            this.lblPorsion.Size = new System.Drawing.Size(91, 24);
            this.lblPorsion.TabIndex = 3;
            this.lblPorsion.Text = "Porsions";
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(28, 285);
            this.dgvFood.MultiSelect = false;
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(683, 357);
            this.dgvFood.TabIndex = 11;
            // 
            // btnAddCustom
            // 
            this.btnAddCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCustom.Location = new System.Drawing.Point(628, 195);
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
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblFood.Location = new System.Drawing.Point(23, 18);
            this.lblFood.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(74, 29);
            this.lblFood.TabIndex = 13;
            this.lblFood.Text = "Food";
            // 
            // pboFood
            // 
            this.pboFood.Location = new System.Drawing.Point(1, 50);
            this.pboFood.Name = "pboFood";
            this.pboFood.Size = new System.Drawing.Size(152, 104);
            this.pboFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboFood.TabIndex = 14;
            this.pboFood.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(537, 194);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 82);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete Food";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 710);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pboFood);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.btnAddCustom);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.lblPorsion);
            this.Controls.Add(this.nudPorsion);
            this.Controls.Add(this.btnUpdateFood);
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
            this.Load += new System.EventHandler(this.FoodsForm_Load);
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
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.NumericUpDown nudPorsion;
        private System.Windows.Forms.Label lblPorsion;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Button btnAddCustom;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.PictureBox pboFood;
        private System.Windows.Forms.Button btnDelete;
    }
}