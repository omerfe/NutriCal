using NutriCal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriCal
{
    public partial class ExerciseEditForm : Form
    {
        private readonly Exercise exercise;
        private readonly UserExercise userExercise;
        private readonly NutriCalDbContext db;
        private readonly User user;

        public ExerciseEditForm(Exercise exercise, NutriCalDbContext db, User user)
        {
            InitializeComponent();
            this.exercise = exercise;
            this.db = db;
            this.user = user;

            if (exercise.ExerciseId > 0)
                PrepareUpdateForm();
            else
                PrepareAddForm();

        }
        public ExerciseEditForm(UserExercise userExercise, NutriCalDbContext db, User user)
        {
            InitializeComponent();
            this.userExercise = userExercise;
            this.db = db;
            this.user = user;
            UpdateUserExercise();
        }

        private void PrepareAddForm()
        {
            lblExerciseName.Text = "";
            txtCustomExerciseName.Show();
            txtCustomExerciseName.Text = "Custom Exercise";
            txtCustomExerciseName.Focus();
            txtCustomExerciseName.SelectAll();
            chbAddAsNew.Visible = false;

        }

        private void PrepareUpdateForm()
        {
            txtCustomExerciseName.Hide();
            lblExerciseName.Text = exercise.ExerciseName;
            nmuBurnedCalorie.Value = (decimal)exercise.BurnedEnergy;
            nmuDuration.Value = exercise.Duration;
            chbAddAsNew.Visible = false;

        }

        private void btnHideExerciseDetails_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            //TODO: Gerekli tokatlamaları yap
            bool isAddAsNewChecked = chbAddAsNew.Checked;


            if (exercise != null || isAddAsNewChecked)
            {
                string exerciseName = (exercise == null) ? txtCustomExerciseName.Text : lblExerciseName.Text;
                Exercise newExercise = new Exercise()
                {
                    ExerciseName = exerciseName,
                    Duration = (int)nmuDuration.Value,
                    ExerciseRole = "U",
                    BurnedEnergy = (double)nmuBurnedCalorie.Value
                };
                UserExercise ue = new UserExercise()
                {
                    User = user,
                    Exercise = newExercise,
                    ExerciseAddedTime = DateTime.Now
                };
                db.UserExercises.Add(ue);
                MessageBox.Show($"{newExercise.ExerciseName} added succesfully!");
            }
            else
            {
                userExercise.Exercise.BurnedEnergy = (double)nmuBurnedCalorie.Value;
                userExercise.Exercise.Duration = (int)nmuDuration.Value;
                userExercise.Exercise.ExerciseName = txtCustomExerciseName.Text;
                MessageBox.Show($"{userExercise.Exercise.ExerciseName} updated successfull!");
                //db.UserExercises = userExercise;
            }
            db.SaveChanges();
            Close();
        }

        private void UpdateUserExercise()
        {
            txtCustomExerciseName.Visible = true;
            Exercise exercise = userExercise.Exercise;
            lblExerciseName.Text = exercise.ExerciseName;
            nmuBurnedCalorie.Value = (decimal)exercise.BurnedEnergy;
            nmuDuration.Value = exercise.Duration;
            txtCustomExerciseName.Text = exercise.ExerciseName;
            btnAddExercise.Text = "Save";
            chbAddAsNew.Visible = true;
        }

        private void txtCustomExerciseName_TextChanged(object sender, EventArgs e)
        {
            lblExerciseName.Text = txtCustomExerciseName.Text;
        }
    }
}
