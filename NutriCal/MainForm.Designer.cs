
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
<<<<<<< HEAD
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
=======
            this.addFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
>>>>>>> 93ea2775903c54b5f2b66d45abad62823fad5dff
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConsumed = new System.Windows.Forms.Label();
            this.lblBurned = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblBudgetInfo = new System.Windows.Forms.Label();
            this.tlpRecomended = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetEnergyHistory = new System.Windows.Forms.Button();
            this.lblShowToday = new System.Windows.Forms.LinkLabel();
            this.cmbDateScala = new System.Windows.Forms.ComboBox();
            this.cmbCalorieBurnType = new System.Windows.Forms.ComboBox();
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.lblDateInfo = new System.Windows.Forms.Label();
            this.pnlConsumed = new System.Windows.Forms.Panel();
            this.pnlBurned = new System.Windows.Forms.Panel();
            this.pnlBudget = new System.Windows.Forms.Panel();
            this.pcbInfo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlConsumed.SuspendLayout();
            this.pnlBurned.SuspendLayout();
            this.pnlBudget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFoodToolStripMenuItem,
            this.addExerciseToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(746, 8);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(421, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
<<<<<<< HEAD
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
=======
>>>>>>> 93ea2775903c54b5f2b66d45abad62823fad5dff
            // addFoodToolStripMenuItem
            // 
            this.addFoodToolStripMenuItem.Image = global::NutriCal.Properties.Resources.food;
            this.addFoodToolStripMenuItem.Name = "addFoodToolStripMenuItem";
<<<<<<< HEAD
            this.addFoodToolStripMenuItem.Size = new System.Drawing.Size(105, 25);
            this.addFoodToolStripMenuItem.Text = "Add Food";
=======
            this.addFoodToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.addFoodToolStripMenuItem.Text = "Add Meal";
>>>>>>> 93ea2775903c54b5f2b66d45abad62823fad5dff
            this.addFoodToolStripMenuItem.Click += new System.EventHandler(this.addFoodToolStripMenuItem_Click);
            // 
            // addExerciseToolStripMenuItem
            // 
            this.addExerciseToolStripMenuItem.Image = global::NutriCal.Properties.Resources.exercise;
            this.addExerciseToolStripMenuItem.Name = "addExerciseToolStripMenuItem";
            this.addExerciseToolStripMenuItem.Size = new System.Drawing.Size(125, 25);
            this.addExerciseToolStripMenuItem.Text = "Add Exercise";
            this.addExerciseToolStripMenuItem.Click += new System.EventHandler(this.addExerciseToolStripMenuItem_Click);
            // 
<<<<<<< HEAD
=======
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Image = global::NutriCal.Properties.Resources.reports;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.historyToolStripMenuItem.Text = "Reports";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
>>>>>>> 93ea2775903c54b5f2b66d45abad62823fad5dff
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::NutriCal.Properties.Resources.logout;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // dgvSummary
            // 
            this.dgvSummary.AllowUserToAddRows = false;
            this.dgvSummary.AllowUserToDeleteRows = false;
            this.dgvSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvSummary.Location = new System.Drawing.Point(295, 64);
            this.dgvSummary.Margin = new System.Windows.Forms.Padding(6);
            this.dgvSummary.MultiSelect = false;
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.ReadOnly = true;
            this.dgvSummary.RowHeadersVisible = false;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvSummary.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSummary.Size = new System.Drawing.Size(861, 469);
            this.dgvSummary.TabIndex = 1;
            this.dgvSummary.SizeChanged += new System.EventHandler(this.dgvSummary_SizeChanged);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Image";
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Unit.DefaultCellStyle = dataGridViewCellStyle10;
            this.Unit.HeaderText = "Energy (kcal)";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // AddedTime
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AddedTime.DefaultCellStyle = dataGridViewCellStyle11;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "CONSUMED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "BURNED";
            // 
            // lblConsumed
            // 
            this.lblConsumed.AutoSize = true;
            this.lblConsumed.Location = new System.Drawing.Point(25, 59);
            this.lblConsumed.Name = "lblConsumed";
            this.lblConsumed.Size = new System.Drawing.Size(20, 24);
            this.lblConsumed.TabIndex = 3;
            this.lblConsumed.Text = "0";
            // 
            // lblBurned
            // 
            this.lblBurned.AutoSize = true;
            this.lblBurned.Location = new System.Drawing.Point(30, 59);
            this.lblBurned.Name = "lblBurned";
            this.lblBurned.Size = new System.Drawing.Size(20, 24);
            this.lblBurned.TabIndex = 3;
            this.lblBurned.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "kcal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "kcal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "kcal";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(32, 59);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(20, 24);
            this.lblBudget.TabIndex = 6;
            this.lblBudget.Text = "0";
            // 
            // lblBudgetInfo
            // 
            this.lblBudgetInfo.AutoSize = true;
            this.lblBudgetInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBudgetInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBudgetInfo.Location = new System.Drawing.Point(34, 8);
            this.lblBudgetInfo.Name = "lblBudgetInfo";
            this.lblBudgetInfo.Size = new System.Drawing.Size(92, 24);
            this.lblBudgetInfo.TabIndex = 5;
            this.lblBudgetInfo.Text = "BUDGET ";
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
            this.groupBox1.Controls.Add(this.btnGetEnergyHistory);
            this.groupBox1.Controls.Add(this.lblShowToday);
            this.groupBox1.Controls.Add(this.cmbDateScala);
            this.groupBox1.Controls.Add(this.cmbCalorieBurnType);
            this.groupBox1.Location = new System.Drawing.Point(26, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 232);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Energy History";
            // 
            // btnGetEnergyHistory
            // 
            this.btnGetEnergyHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetEnergyHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetEnergyHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetEnergyHistory.Location = new System.Drawing.Point(26, 155);
            this.btnGetEnergyHistory.Name = "btnGetEnergyHistory";
            this.btnGetEnergyHistory.Size = new System.Drawing.Size(212, 29);
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
            this.lblShowToday.Location = new System.Drawing.Point(175, 194);
            this.lblShowToday.Name = "lblShowToday";
            this.lblShowToday.Size = new System.Drawing.Size(63, 24);
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
            this.cmbDateScala.Location = new System.Drawing.Point(26, 103);
            this.cmbDateScala.Name = "cmbDateScala";
            this.cmbDateScala.Size = new System.Drawing.Size(212, 32);
            this.cmbDateScala.TabIndex = 1;
            // 
            // cmbCalorieBurnType
            // 
            this.cmbCalorieBurnType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalorieBurnType.FormattingEnabled = true;
            this.cmbCalorieBurnType.Items.AddRange(new object[] {
            "Exercises (Burned)",
            "Meals and what you eat (Consumed)",
            "Both (Net)"});
            this.cmbCalorieBurnType.Location = new System.Drawing.Point(26, 49);
            this.cmbCalorieBurnType.Name = "cmbCalorieBurnType";
            this.cmbCalorieBurnType.Size = new System.Drawing.Size(212, 32);
            this.cmbCalorieBurnType.TabIndex = 0;
            // 
            // mcDate
            // 
            this.mcDate.Location = new System.Drawing.Point(41, 64);
            this.mcDate.MaxSelectionCount = 1;
            this.mcDate.Name = "mcDate";
            this.mcDate.TabIndex = 10;
            this.mcDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcDate_DateChanged);
            // 
            // lblDateInfo
            // 
            this.lblDateInfo.AutoSize = true;
            this.lblDateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateInfo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDateInfo.Location = new System.Drawing.Point(659, 41);
            this.lblDateInfo.Name = "lblDateInfo";
            this.lblDateInfo.Size = new System.Drawing.Size(0, 17);
            this.lblDateInfo.TabIndex = 11;
            // 
            // pnlConsumed
            // 
            this.pnlConsumed.Controls.Add(this.label3);
            this.pnlConsumed.Controls.Add(this.label1);
            this.pnlConsumed.Controls.Add(this.lblConsumed);
            this.pnlConsumed.Location = new System.Drawing.Point(425, 555);
            this.pnlConsumed.Name = "pnlConsumed";
            this.pnlConsumed.Size = new System.Drawing.Size(157, 123);
            this.pnlConsumed.TabIndex = 12;
            // 
            // pnlBurned
            // 
            this.pnlBurned.Controls.Add(this.lblBurned);
            this.pnlBurned.Controls.Add(this.label2);
            this.pnlBurned.Controls.Add(this.label4);
            this.pnlBurned.Location = new System.Drawing.Point(614, 555);
            this.pnlBurned.Name = "pnlBurned";
            this.pnlBurned.Size = new System.Drawing.Size(157, 123);
            this.pnlBurned.TabIndex = 13;
            // 
            // pnlBudget
            // 
            this.pnlBudget.Controls.Add(this.pcbInfo);
            this.pnlBudget.Controls.Add(this.label5);
            this.pnlBudget.Controls.Add(this.lblBudgetInfo);
            this.pnlBudget.Controls.Add(this.lblBudget);
            this.pnlBudget.Location = new System.Drawing.Point(803, 555);
            this.pnlBudget.Name = "pnlBudget";
            this.pnlBudget.Size = new System.Drawing.Size(157, 123);
            this.pnlBudget.TabIndex = 13;
            // 
            // pcbInfo
            // 
            this.pcbInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.pcbInfo.Image = global::NutriCal.Properties.Resources.info;
            this.pcbInfo.Location = new System.Drawing.Point(123, 10);
            this.pcbInfo.Name = "pcbInfo";
            this.pcbInfo.Size = new System.Drawing.Size(20, 20);
            this.pcbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbInfo.TabIndex = 14;
            this.pcbInfo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 688);
            this.Controls.Add(this.pnlBudget);
            this.Controls.Add(this.pnlBurned);
            this.Controls.Add(this.pnlConsumed);
            this.Controls.Add(this.lblDateInfo);
            this.Controls.Add(this.mcDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSummary);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlConsumed.ResumeLayout(false);
            this.pnlConsumed.PerformLayout();
            this.pnlBurned.ResumeLayout(false);
            this.pnlBurned.PerformLayout();
            this.pnlBudget.ResumeLayout(false);
            this.pnlBudget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExerciseToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConsumed;
        private System.Windows.Forms.Label lblBurned;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblBudgetInfo;
        private System.Windows.Forms.ToolTip tlpRecomended;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDateScala;
        private System.Windows.Forms.ComboBox cmbCalorieBurnType;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.Label lblDateInfo;
        private System.Windows.Forms.LinkLabel lblShowToday;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel pnlConsumed;
        private System.Windows.Forms.Panel pnlBurned;
        private System.Windows.Forms.Panel pnlBudget;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button btnGetEnergyHistory;
        private System.Windows.Forms.PictureBox pcbInfo;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
    }
}