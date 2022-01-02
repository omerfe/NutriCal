
namespace NutriCal
{
    partial class ExerciseEditForm
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
            this.txtCustomExerciseName = new System.Windows.Forms.TextBox();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.lblExerciseName = new System.Windows.Forms.Label();
            this.btnHideExerciseDetails = new System.Windows.Forms.Button();
            this.nmuDuration = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmuBurnedCalorie = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chbAddAsNew = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmuDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuBurnedCalorie)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomExerciseName
            // 
            this.txtCustomExerciseName.Location = new System.Drawing.Point(22, 17);
            this.txtCustomExerciseName.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustomExerciseName.Name = "txtCustomExerciseName";
            this.txtCustomExerciseName.Size = new System.Drawing.Size(253, 29);
            this.txtCustomExerciseName.TabIndex = 18;
            this.txtCustomExerciseName.TextChanged += new System.EventHandler(this.txtCustomExerciseName_TextChanged);
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.Location = new System.Drawing.Point(26, 260);
            this.btnAddExercise.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(672, 57);
            this.btnAddExercise.TabIndex = 17;
            this.btnAddExercise.Text = "Add";
            this.btnAddExercise.UseVisualStyleBackColor = true;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // lblExerciseName
            // 
            this.lblExerciseName.AutoSize = true;
            this.lblExerciseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExerciseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblExerciseName.Location = new System.Drawing.Point(309, 18);
            this.lblExerciseName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExerciseName.Name = "lblExerciseName";
            this.lblExerciseName.Size = new System.Drawing.Size(99, 29);
            this.lblExerciseName.TabIndex = 16;
            this.lblExerciseName.Text = "Walking";
            // 
            // btnHideExerciseDetails
            // 
            this.btnHideExerciseDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHideExerciseDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideExerciseDetails.Location = new System.Drawing.Point(626, 5);
            this.btnHideExerciseDetails.Margin = new System.Windows.Forms.Padding(6);
            this.btnHideExerciseDetails.Name = "btnHideExerciseDetails";
            this.btnHideExerciseDetails.Size = new System.Drawing.Size(72, 55);
            this.btnHideExerciseDetails.TabIndex = 15;
            this.btnHideExerciseDetails.Text = "X";
            this.btnHideExerciseDetails.UseVisualStyleBackColor = true;
            this.btnHideExerciseDetails.Click += new System.EventHandler(this.btnHideExerciseDetails_Click);
            // 
            // nmuDuration
            // 
            this.nmuDuration.Location = new System.Drawing.Point(531, 125);
            this.nmuDuration.Margin = new System.Windows.Forms.Padding(6);
            this.nmuDuration.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.nmuDuration.Name = "nmuDuration";
            this.nmuDuration.Size = new System.Drawing.Size(114, 29);
            this.nmuDuration.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Duration";
            // 
            // nmuBurnedCalorie
            // 
            this.nmuBurnedCalorie.DecimalPlaces = 1;
            this.nmuBurnedCalorie.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmuBurnedCalorie.Location = new System.Drawing.Point(161, 122);
            this.nmuBurnedCalorie.Margin = new System.Windows.Forms.Padding(6);
            this.nmuBurnedCalorie.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmuBurnedCalorie.Name = "nmuBurnedCalorie";
            this.nmuBurnedCalorie.Size = new System.Drawing.Size(114, 29);
            this.nmuBurnedCalorie.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "kcal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Burned Energy";
            // 
            // chbAddAsNew
            // 
            this.chbAddAsNew.AutoSize = true;
            this.chbAddAsNew.Location = new System.Drawing.Point(26, 65);
            this.chbAddAsNew.Name = "chbAddAsNew";
            this.chbAddAsNew.Size = new System.Drawing.Size(206, 28);
            this.chbAddAsNew.TabIndex = 19;
            this.chbAddAsNew.Text = "Add as new exercise";
            this.chbAddAsNew.UseVisualStyleBackColor = true;
            this.chbAddAsNew.Visible = false;
            // 
            // ExerciseEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(742, 349);
            this.Controls.Add(this.chbAddAsNew);
            this.Controls.Add(this.txtCustomExerciseName);
            this.Controls.Add(this.btnAddExercise);
            this.Controls.Add(this.lblExerciseName);
            this.Controls.Add(this.btnHideExerciseDetails);
            this.Controls.Add(this.nmuDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmuBurnedCalorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ExerciseEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExerciseEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.nmuDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuBurnedCalorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomExerciseName;
        private System.Windows.Forms.Button btnAddExercise;
        private System.Windows.Forms.Label lblExerciseName;
        private System.Windows.Forms.Button btnHideExerciseDetails;
        private System.Windows.Forms.NumericUpDown nmuDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmuBurnedCalorie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbAddAsNew;
    }
}