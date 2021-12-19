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
        private readonly NutriCalDbContext db;
        private readonly User user;

        public ExerciseEditForm(Exercise exercise, NutriCalDbContext db, User user)
        {
            InitializeComponent();
            this.exercise = exercise;
            this.db = db;
            this.user = user;
            if (exercise == null)
            {
                PrepareAddForm();
            }
            else
            {
                PrepareUpdateForm();
            }
        }

        private void PrepareAddForm()
        {
            lblExerciseName.Text = "";
            txtCustomExerciseName.Show();
            txtCustomExerciseName.Text = "Custom Exercise";
            txtCustomExerciseName.Focus();
            txtCustomExerciseName.SelectAll();
        }

        private void PrepareUpdateForm()
        {
            txtCustomExerciseName.Hide();
            lblExerciseName.Text = exercise.ExerciseName;
            nmuBurnedCalorie.Value = (decimal)exercise.BurnedEnergy;
            nmuDuration.Value = exercise.Duration;
        }

        private void btnHideExerciseDetails_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            //TODO: Gerekli tokatlamaları yap
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
            MessageBox.Show(ue.ExerciseAddedTime.ToString());
            db.UserExercises.Add(ue);
            db.SaveChanges();
            MessageBox.Show($"{newExercise.ExerciseName} has been added succesfully!");
            Close(); 
        }

        private void txtCustomExerciseName_TextChanged(object sender, EventArgs e)
        {
            lblExerciseName.Text = txtCustomExerciseName.Text;
        }
    }
}
