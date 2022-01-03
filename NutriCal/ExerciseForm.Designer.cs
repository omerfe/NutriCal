
namespace NutriCal
{
    partial class ExerciseForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExerciseForm));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.imgExercises = new System.Windows.Forms.ImageList(this.components);
            this.tcExercises = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvMostRecents = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lsvExercises = new System.Windows.Forms.ListView();
            this.btnAddCustomExercise = new System.Windows.Forms.Button();
            this.cmsRecentExercises = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateExerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcExercises.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostRecents)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.cmsRecentExercises.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(15, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(700, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // imgExercises
            // 
            this.imgExercises.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgExercises.ImageStream")));
            this.imgExercises.TransparentColor = System.Drawing.Color.Transparent;
            this.imgExercises.Images.SetKeyName(0, "walking");
            this.imgExercises.Images.SetKeyName(1, "swimming");
            this.imgExercises.Images.SetKeyName(2, "running");
            this.imgExercises.Images.SetKeyName(3, "basketball");
            this.imgExercises.Images.SetKeyName(4, "cleaning");
            this.imgExercises.Images.SetKeyName(5, "cycling");
            this.imgExercises.Images.SetKeyName(6, "dancing");
            this.imgExercises.Images.SetKeyName(7, "gym");
            this.imgExercises.Images.SetKeyName(8, "hunting");
            this.imgExercises.Images.SetKeyName(9, "jumping rope");
            this.imgExercises.Images.SetKeyName(10, "volleyball");
            this.imgExercises.Images.SetKeyName(11, "Billiards");
            this.imgExercises.Images.SetKeyName(12, "Bowling");
            this.imgExercises.Images.SetKeyName(13, "Diving");
            this.imgExercises.Images.SetKeyName(14, "Polo");
            this.imgExercises.Images.SetKeyName(15, "Soccer");
            this.imgExercises.Images.SetKeyName(16, "Surfing");
            this.imgExercises.Images.SetKeyName(17, "Windsurfing");
            this.imgExercises.Images.SetKeyName(18, "Yoga");
            // 
            // tcExercises
            // 
            this.tcExercises.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcExercises.Controls.Add(this.tabPage1);
            this.tcExercises.Controls.Add(this.tabPage2);
            this.tcExercises.Location = new System.Drawing.Point(15, 93);
            this.tcExercises.Name = "tcExercises";
            this.tcExercises.SelectedIndex = 0;
            this.tcExercises.Size = new System.Drawing.Size(704, 509);
            this.tcExercises.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvMostRecents);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Most Recent";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvMostRecents
            // 
            this.dgvMostRecents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostRecents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMostRecents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostRecents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMostRecents.Location = new System.Drawing.Point(3, 3);
            this.dgvMostRecents.MultiSelect = false;
            this.dgvMostRecents.Name = "dgvMostRecents";
            this.dgvMostRecents.RowHeadersVisible = false;
            this.dgvMostRecents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostRecents.Size = new System.Drawing.Size(690, 466);
            this.dgvMostRecents.TabIndex = 0;
            this.dgvMostRecents.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMostRecents_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lsvExercises);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Browse All";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lsvExercises
            // 
            this.lsvExercises.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvExercises.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvExercises.HideSelection = false;
            this.lsvExercises.LargeImageList = this.imgExercises;
            this.lsvExercises.Location = new System.Drawing.Point(3, 3);
            this.lsvExercises.Name = "lsvExercises";
            this.lsvExercises.Size = new System.Drawing.Size(690, 466);
            this.lsvExercises.TabIndex = 2;
            this.lsvExercises.UseCompatibleStateImageBehavior = false;
            this.lsvExercises.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvExercises_MouseDoubleClick);
            // 
            // btnAddCustomExercise
            // 
            this.btnAddCustomExercise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCustomExercise.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddCustomExercise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCustomExercise.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCustomExercise.Location = new System.Drawing.Point(511, 53);
            this.btnAddCustomExercise.Name = "btnAddCustomExercise";
            this.btnAddCustomExercise.Size = new System.Drawing.Size(200, 32);
            this.btnAddCustomExercise.TabIndex = 3;
            this.btnAddCustomExercise.Text = "Add Custom Exercise";
            this.btnAddCustomExercise.UseVisualStyleBackColor = false;
            this.btnAddCustomExercise.Click += new System.EventHandler(this.btnAddCustomExercise_Click);
            // 
            // cmsRecentExercises
            // 
            this.cmsRecentExercises.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateExerciseToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsRecentExercises.Name = "cmsRecentExercises";
            this.cmsRecentExercises.Size = new System.Drawing.Size(110, 48);
            // 
            // updateExerciseToolStripMenuItem
            // 
            this.updateExerciseToolStripMenuItem.Image = global::NutriCal.Properties.Resources.update;
            this.updateExerciseToolStripMenuItem.Name = "updateExerciseToolStripMenuItem";
            this.updateExerciseToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.updateExerciseToolStripMenuItem.Text = "Details";
            this.updateExerciseToolStripMenuItem.Click += new System.EventHandler(this.updateExerciseToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::NutriCal.Properties.Resources.delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 626);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.tcExercises);
            this.Controls.Add(this.btnAddCustomExercise);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ExerciseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EXERCISES";
            this.tcExercises.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostRecents)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.cmsRecentExercises.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ImageList imgExercises;
        private System.Windows.Forms.TabControl tcExercises;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddCustomExercise;
        private System.Windows.Forms.ListView lsvExercises;
        private System.Windows.Forms.DataGridView dgvMostRecents;
        private System.Windows.Forms.ContextMenuStrip cmsRecentExercises;
        private System.Windows.Forms.ToolStripMenuItem updateExerciseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}