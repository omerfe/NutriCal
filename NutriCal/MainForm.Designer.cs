
namespace NutriCal
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblConsumed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tlpRecomended = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGetEnergyHistory = new System.Windows.Forms.Button();
            this.lblShowToday = new System.Windows.Forms.LinkLabel();
            this.cmbDateScala = new System.Windows.Forms.ComboBox();
            this.cmbCalorieBurnType = new System.Windows.Forms.ComboBox();
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.lblDateInfo = new System.Windows.Forms.Label();
            this.pcbInfo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlConsumed = new System.Windows.Forms.GroupBox();
            this.pnlBurned = new System.Windows.Forms.GroupBox();
            this.lblBurned = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBudget = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlConsumed.SuspendLayout();
            this.pnlBurned.SuspendLayout();
            this.pnlBudget.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFoodToolStripMenuItem,
            this.addExerciseToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 20, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(144, 676);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addFoodToolStripMenuItem
            // 
            this.addFoodToolStripMenuItem.Image = global::NutriCal.Properties.Resources.food;
            this.addFoodToolStripMenuItem.Name = "addFoodToolStripMenuItem";
            this.addFoodToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 50, 4, 50);
            this.addFoodToolStripMenuItem.Size = new System.Drawing.Size(125, 125);
            this.addFoodToolStripMenuItem.Text = "Add Meal";
            this.addFoodToolStripMenuItem.Click += new System.EventHandler(this.addFoodToolStripMenuItem_Click);
            // 
            // addExerciseToolStripMenuItem
            // 
            this.addExerciseToolStripMenuItem.Image = global::NutriCal.Properties.Resources.exercise;
            this.addExerciseToolStripMenuItem.Name = "addExerciseToolStripMenuItem";
            this.addExerciseToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 50, 4, 50);
            this.addExerciseToolStripMenuItem.Size = new System.Drawing.Size(125, 125);
            this.addExerciseToolStripMenuItem.Text = "Add Exercise";
            this.addExerciseToolStripMenuItem.Click += new System.EventHandler(this.addExerciseToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Image = global::NutriCal.Properties.Resources.reports;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 50, 4, 50);
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(125, 125);
            this.historyToolStripMenuItem.Text = "Reports";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::NutriCal.Properties.Resources.logout;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 50, 4, 50);
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(125, 125);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // dgvSummary
            // 
            this.dgvSummary.AllowUserToAddRows = false;
            this.dgvSummary.AllowUserToDeleteRows = false;
            this.dgvSummary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column3,
            this.Column2,
            this.Unit,
            this.AddedTime,
            this.Column5});
            this.dgvSummary.Location = new System.Drawing.Point(149, 34);
            this.dgvSummary.Margin = new System.Windows.Forms.Padding(5);
            this.dgvSummary.MultiSelect = false;
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.ReadOnly = true;
            this.dgvSummary.RowHeadersVisible = false;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvSummary.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSummary.Size = new System.Drawing.Size(970, 495);
            this.dgvSummary.TabIndex = 1;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 27;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 300F;
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 20;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column3.FillWeight = 30F;
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 55;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 30F;
            this.Column2.HeaderText = "Unit";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 56;
            // 
            // Unit
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Unit.DefaultCellStyle = dataGridViewCellStyle14;
            this.Unit.HeaderText = "Energy (kcal)";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // AddedTime
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AddedTime.DefaultCellStyle = dataGridViewCellStyle15;
            this.AddedTime.HeaderText = "Time";
            this.AddedTime.Name = "AddedTime";
            this.AddedTime.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // lblConsumed
            // 
            this.lblConsumed.AutoSize = true;
            this.lblConsumed.Location = new System.Drawing.Point(19, 52);
            this.lblConsumed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsumed.Name = "lblConsumed";
            this.lblConsumed.Size = new System.Drawing.Size(84, 30);
            this.lblConsumed.TabIndex = 3;
            this.lblConsumed.Text = "999,99";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "kcal";
            // 
            // tlpRecomended
            // 
            this.tlpRecomended.AutoPopDelay = 5000;
            this.tlpRecomended.InitialDelay = 1;
            this.tlpRecomended.ReshowDelay = 100;
            this.tlpRecomended.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnGetEnergyHistory);
            this.groupBox1.Controls.Add(this.lblShowToday);
            this.groupBox1.Controls.Add(this.cmbDateScala);
            this.groupBox1.Controls.Add(this.cmbCalorieBurnType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1126, 207);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(234, 322);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Energy History";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Energy Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Time Interval";
            // 
            // btnGetEnergyHistory
            // 
            this.btnGetEnergyHistory.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetEnergyHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetEnergyHistory.Location = new System.Drawing.Point(21, 205);
            this.btnGetEnergyHistory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGetEnergyHistory.Name = "btnGetEnergyHistory";
            this.btnGetEnergyHistory.Size = new System.Drawing.Size(198, 33);
            this.btnGetEnergyHistory.TabIndex = 3;
            this.btnGetEnergyHistory.Text = "Get My History";
            this.btnGetEnergyHistory.UseVisualStyleBackColor = false;
            this.btnGetEnergyHistory.Click += new System.EventHandler(this.btnGetEnergyHistory_Click);
            // 
            // lblShowToday
            // 
            this.lblShowToday.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShowToday.AutoSize = true;
            this.lblShowToday.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShowToday.Location = new System.Drawing.Point(169, 288);
            this.lblShowToday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowToday.Name = "lblShowToday";
            this.lblShowToday.Size = new System.Drawing.Size(56, 21);
            this.lblShowToday.TabIndex = 2;
            this.lblShowToday.TabStop = true;
            this.lblShowToday.Text = "Today";
            this.lblShowToday.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowToday_LinkClicked);
            // 
            // cmbDateScala
            // 
            this.cmbDateScala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateScala.FormattingEnabled = true;
            this.cmbDateScala.Items.AddRange(new object[] {
            "Last 1 Week",
            "Last 2 Weeks",
            "Last 1 Month",
            "Last 3 Months"});
            this.cmbDateScala.Location = new System.Drawing.Point(21, 139);
            this.cmbDateScala.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbDateScala.Name = "cmbDateScala";
            this.cmbDateScala.Size = new System.Drawing.Size(198, 29);
            this.cmbDateScala.TabIndex = 1;
            // 
            // cmbCalorieBurnType
            // 
            this.cmbCalorieBurnType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalorieBurnType.FormattingEnabled = true;
            this.cmbCalorieBurnType.Items.AddRange(new object[] {
            "Exercises (Burned)",
            "Meals (Consumed)",
            "Both (Net)"});
            this.cmbCalorieBurnType.Location = new System.Drawing.Point(21, 67);
            this.cmbCalorieBurnType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbCalorieBurnType.Name = "cmbCalorieBurnType";
            this.cmbCalorieBurnType.Size = new System.Drawing.Size(198, 29);
            this.cmbCalorieBurnType.TabIndex = 0;
            // 
            // mcDate
            // 
            this.mcDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mcDate.Location = new System.Drawing.Point(1126, 34);
            this.mcDate.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.mcDate.MaxSelectionCount = 1;
            this.mcDate.Name = "mcDate";
            this.mcDate.TabIndex = 10;
            this.mcDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcDate_DateChanged);
            // 
            // lblDateInfo
            // 
            this.lblDateInfo.AutoSize = true;
            this.lblDateInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateInfo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDateInfo.Location = new System.Drawing.Point(146, 9);
            this.lblDateInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateInfo.Name = "lblDateInfo";
            this.lblDateInfo.Size = new System.Drawing.Size(0, 17);
            this.lblDateInfo.TabIndex = 11;
            // 
            // pcbInfo
            // 
            this.pcbInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.pcbInfo.Image = global::NutriCal.Properties.Resources.info;
            this.pcbInfo.Location = new System.Drawing.Point(90, 6);
            this.pcbInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pcbInfo.Name = "pcbInfo";
            this.pcbInfo.Size = new System.Drawing.Size(20, 20);
            this.pcbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbInfo.TabIndex = 14;
            this.pcbInfo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NutriCal.Properties.Resources.GoldU;
            this.pictureBox1.Location = new System.Drawing.Point(1121, 532);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pnlConsumed
            // 
            this.pnlConsumed.Controls.Add(this.label3);
            this.pnlConsumed.Controls.Add(this.lblConsumed);
            this.pnlConsumed.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlConsumed.Location = new System.Drawing.Point(316, 548);
            this.pnlConsumed.Name = "pnlConsumed";
            this.pnlConsumed.Size = new System.Drawing.Size(149, 116);
            this.pnlConsumed.TabIndex = 15;
            this.pnlConsumed.TabStop = false;
            this.pnlConsumed.Text = "Consumed";
            // 
            // pnlBurned
            // 
            this.pnlBurned.Controls.Add(this.lblBurned);
            this.pnlBurned.Controls.Add(this.label4);
            this.pnlBurned.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlBurned.Location = new System.Drawing.Point(559, 548);
            this.pnlBurned.Name = "pnlBurned";
            this.pnlBurned.Size = new System.Drawing.Size(149, 116);
            this.pnlBurned.TabIndex = 16;
            this.pnlBurned.TabStop = false;
            this.pnlBurned.Text = "Burned";
            // 
            // lblBurned
            // 
            this.lblBurned.AutoSize = true;
            this.lblBurned.Location = new System.Drawing.Point(5, 52);
            this.lblBurned.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBurned.Name = "lblBurned";
            this.lblBurned.Size = new System.Drawing.Size(84, 30);
            this.lblBurned.TabIndex = 5;
            this.lblBurned.Text = "999,99";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "kcal";
            // 
            // pnlBudget
            // 
            this.pnlBudget.Controls.Add(this.label5);
            this.pnlBudget.Controls.Add(this.lblBudget);
            this.pnlBudget.Controls.Add(this.pcbInfo);
            this.pnlBudget.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlBudget.Location = new System.Drawing.Point(802, 548);
            this.pnlBudget.Name = "pnlBudget";
            this.pnlBudget.Size = new System.Drawing.Size(149, 116);
            this.pnlBudget.TabIndex = 17;
            this.pnlBudget.TabStop = false;
            this.pnlBudget.Text = "Budget";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "kcal";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(11, 52);
            this.lblBudget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(84, 30);
            this.lblBudget.TabIndex = 15;
            this.lblBudget.Text = "999,99";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 676);
            this.Controls.Add(this.pnlBudget);
            this.Controls.Add(this.pnlBurned);
            this.Controls.Add(this.pnlConsumed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDateInfo);
            this.Controls.Add(this.mcDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSummary);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUTRICAL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlConsumed.ResumeLayout(false);
            this.pnlConsumed.PerformLayout();
            this.pnlBurned.ResumeLayout(false);
            this.pnlBurned.PerformLayout();
            this.pnlBudget.ResumeLayout(false);
            this.pnlBudget.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExerciseToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.Label lblConsumed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip tlpRecomended;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDateScala;
        private System.Windows.Forms.ComboBox cmbCalorieBurnType;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.Label lblDateInfo;
        private System.Windows.Forms.LinkLabel lblShowToday;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button btnGetEnergyHistory;
        private System.Windows.Forms.PictureBox pcbInfo;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox pnlConsumed;
        private System.Windows.Forms.GroupBox pnlBurned;
        private System.Windows.Forms.Label lblBurned;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox pnlBudget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}