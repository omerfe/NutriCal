namespace NutriCal
{
    partial class FoodEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomFoodName = new System.Windows.Forms.TextBox();
            this.lblPorsions = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.nudPorsion = new System.Windows.Forms.NumericUpDown();
            this.nudCalories = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtCustomFoodImage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboPorsion = new System.Windows.Forms.ComboBox();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalories)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Name:";
            // 
            // txtCustomFoodName
            // 
            this.txtCustomFoodName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomFoodName.Location = new System.Drawing.Point(16, 104);
            this.txtCustomFoodName.Name = "txtCustomFoodName";
            this.txtCustomFoodName.Size = new System.Drawing.Size(212, 29);
            this.txtCustomFoodName.TabIndex = 1;
            // 
            // lblPorsions
            // 
            this.lblPorsions.AutoSize = true;
            this.lblPorsions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPorsions.Location = new System.Drawing.Point(12, 219);
            this.lblPorsions.Name = "lblPorsions";
            this.lblPorsions.Size = new System.Drawing.Size(110, 21);
            this.lblPorsions.TabIndex = 2;
            this.lblPorsions.Text = "Porsion(s) in:";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalories.Location = new System.Drawing.Point(12, 356);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(112, 21);
            this.lblCalories.TabIndex = 4;
            this.lblCalories.Text = "Calorie(s) per";
            // 
            // nudPorsion
            // 
            this.nudPorsion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudPorsion.Location = new System.Drawing.Point(16, 311);
            this.nudPorsion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPorsion.Name = "nudPorsion";
            this.nudPorsion.Size = new System.Drawing.Size(212, 29);
            this.nudPorsion.TabIndex = 6;
            this.nudPorsion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPorsion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPorsion.ValueChanged += new System.EventHandler(this.nudPorsion_ValueChanged);
            // 
            // nudCalories
            // 
            this.nudCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudCalories.Location = new System.Drawing.Point(16, 381);
            this.nudCalories.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCalories.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCalories.Name = "nudCalories";
            this.nudCalories.Size = new System.Drawing.Size(212, 29);
            this.nudCalories.TabIndex = 7;
            this.nudCalories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCalories.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCalories.ValueChanged += new System.EventHandler(this.nudCalories_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category:";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(16, 32);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(212, 29);
            this.cboCategory.TabIndex = 9;
            // 
            // txtCustomFoodImage
            // 
            this.txtCustomFoodImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomFoodImage.Location = new System.Drawing.Point(16, 174);
            this.txtCustomFoodImage.Name = "txtCustomFoodImage";
            this.txtCustomFoodImage.Size = new System.Drawing.Size(212, 29);
            this.txtCustomFoodImage.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Food Image:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(16, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 30);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(140, 455);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 30);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboPorsion
            // 
            this.cboPorsion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPorsion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboPorsion.FormattingEnabled = true;
            this.cboPorsion.Location = new System.Drawing.Point(16, 246);
            this.cboPorsion.Name = "cboPorsion";
            this.cboPorsion.Size = new System.Drawing.Size(212, 29);
            this.cboPorsion.TabIndex = 15;
            this.cboPorsion.SelectedIndexChanged += new System.EventHandler(this.cboPorsion_SelectedIndexChanged);
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalCalories.Location = new System.Drawing.Point(12, 418);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(117, 21);
            this.lblTotalCalories.TabIndex = 16;
            this.lblTotalCalories.Text = "Total Calories:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Quantity:";
            // 
            // FoodEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.cboPorsion);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCustomFoodImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudCalories);
            this.Controls.Add(this.nudPorsion);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblPorsions);
            this.Controls.Add(this.txtCustomFoodName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FoodEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomFoodName;
        private System.Windows.Forms.Label lblPorsions;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.NumericUpDown nudPorsion;
        private System.Windows.Forms.NumericUpDown nudCalories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtCustomFoodImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboPorsion;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Label label2;
    }
}