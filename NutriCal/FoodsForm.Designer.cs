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
            this.cboFoods = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pboSelectedMeal = new System.Windows.Forms.PictureBox();
            this.cboFoodCategories = new System.Windows.Forms.ComboBox();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.nudPorsion = new System.Windows.Forms.NumericUpDown();
            this.lblPorsion = new System.Windows.Forms.Label();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.btnAddCustom = new System.Windows.Forms.Button();
            this.pboFood = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboSelectedMeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFood)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboFoods
            // 
            this.cboFoods.BackColor = System.Drawing.SystemColors.Control;
            this.cboFoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoods.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboFoods.FormattingEnabled = true;
            this.cboFoods.Location = new System.Drawing.Point(20, 325);
            this.cboFoods.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cboFoods.Name = "cboFoods";
            this.cboFoods.Size = new System.Drawing.Size(379, 29);
            this.cboFoods.TabIndex = 2;
            this.cboFoods.SelectedIndexChanged += new System.EventHandler(this.cboFoods_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(291, 375);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 40);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Food";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pboSelectedMeal
            // 
            this.pboSelectedMeal.Location = new System.Drawing.Point(231, 28);
            this.pboSelectedMeal.Name = "pboSelectedMeal";
            this.pboSelectedMeal.Size = new System.Drawing.Size(200, 125);
            this.pboSelectedMeal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboSelectedMeal.TabIndex = 5;
            this.pboSelectedMeal.TabStop = false;
            // 
            // cboFoodCategories
            // 
            this.cboFoodCategories.BackColor = System.Drawing.SystemColors.Control;
            this.cboFoodCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoodCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboFoodCategories.FormattingEnabled = true;
            this.cboFoodCategories.Location = new System.Drawing.Point(17, 253);
            this.cboFoodCategories.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cboFoodCategories.Name = "cboFoodCategories";
            this.cboFoodCategories.Size = new System.Drawing.Size(382, 29);
            this.cboFoodCategories.TabIndex = 1;
            this.cboFoodCategories.SelectedIndexChanged += new System.EventHandler(this.cboFoodCategories_SelectedIndexChanged);
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateFood.Location = new System.Drawing.Point(1211, 617);
            this.btnUpdateFood.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(144, 45);
            this.btnUpdateFood.TabIndex = 8;
            this.btnUpdateFood.Text = "Update Food";
            this.btnUpdateFood.UseVisualStyleBackColor = true;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // nudPorsion
            // 
            this.nudPorsion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudPorsion.Location = new System.Drawing.Point(187, 382);
            this.nudPorsion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPorsion.Name = "nudPorsion";
            this.nudPorsion.Size = new System.Drawing.Size(81, 29);
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
            this.lblPorsion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPorsion.Location = new System.Drawing.Point(20, 385);
            this.lblPorsion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPorsion.Name = "lblPorsion";
            this.lblPorsion.Size = new System.Drawing.Size(75, 21);
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
            this.dgvFood.Location = new System.Drawing.Point(675, 19);
            this.dgvFood.MultiSelect = false;
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(683, 590);
            this.dgvFood.TabIndex = 11;
            // 
            // btnAddCustom
            // 
            this.btnAddCustom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCustom.Location = new System.Drawing.Point(20, 470);
            this.btnAddCustom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAddCustom.Name = "btnAddCustom";
            this.btnAddCustom.Size = new System.Drawing.Size(379, 50);
            this.btnAddCustom.TabIndex = 12;
            this.btnAddCustom.Text = "Add Custom Food";
            this.btnAddCustom.UseVisualStyleBackColor = true;
            this.btnAddCustom.Click += new System.EventHandler(this.btnAddCustom_Click);
            // 
            // pboFood
            // 
            this.pboFood.Location = new System.Drawing.Point(445, 253);
            this.pboFood.Name = "pboFood";
            this.pboFood.Size = new System.Drawing.Size(155, 109);
            this.pboFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboFood.TabIndex = 14;
            this.pboFood.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(1058, 617);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 45);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete Food";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 299);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Foods";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddCustom);
            this.groupBox1.Controls.Add(this.pboFood);
            this.groupBox1.Controls.Add(this.cboFoods);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cboFoodCategories);
            this.groupBox1.Controls.Add(this.nudPorsion);
            this.groupBox1.Controls.Add(this.lblPorsion);
            this.groupBox1.Controls.Add(this.pboSelectedMeal);
            this.groupBox1.Location = new System.Drawing.Point(29, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 590);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // FoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 676);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.btnUpdateFood);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FoodsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodsForm";
            this.Load += new System.EventHandler(this.FoodsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboSelectedMeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFood)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboFoods;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pboSelectedMeal;
        private System.Windows.Forms.ComboBox cboFoodCategories;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.NumericUpDown nudPorsion;
        private System.Windows.Forms.Label lblPorsion;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Button btnAddCustom;
        private System.Windows.Forms.PictureBox pboFood;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}